using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnTraiCay
{
    public partial class frmSanPham : Form
    {
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\DoAnTraiCay\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public frmSanPham()
        {
            InitializeComponent();
            con = new SqlConnection(connectstring);
        }

        private void ShowSanPham(string query)
        {
            try
            {
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear(); // Xóa dữ liệu cũ
                adt.Fill(dt);
                dtgSanpham.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            TangMaSP();
        
            DataTable dtNhaCC = HienThiNhaCC();
            try
            {
                con.Open();
                // Lấy dữ liệu mới từ cơ sở dữ liệu
                cmd = new SqlCommand("SELECT * FROM SANPHAM", con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear(); // Xóa dữ liệu cũ trong DataTable
                adt.Fill(dt); // Lấy dữ liệu mới từ cơ sở dữ liệu
                dtgSanpham.DataSource = dt; // Cập nhật lại DataSource của DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            NhacNho();
        }

        private DataTable HienThiNhaCC()
        {
            DataTable dtNhaCC = new DataTable();
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT MaNCC, TenNCC FROM NHACUNGCAP";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtNhaCC);
                cbb_TenNCC.DataSource = dtNhaCC;
                cbb_TenNCC.DisplayMember = "TenNCC";
                cbb_TenNCC.ValueMember = "MaNCC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dtNhaCC;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          
           try
            {
                if (!string.IsNullOrEmpty(txt_MaSP.Text) && !string.IsNullOrEmpty(txtTenSp.Text) && !string.IsNullOrEmpty(cbDonVi.Text) && !string.IsNullOrEmpty(nb_soluong.Text) && !string.IsNullOrEmpty(txtGiaBan.Text) && !string.IsNullOrEmpty(txtGiaNhap.Text) && !string.IsNullOrEmpty(cbb_TenNCC.Text))
                {
                    string ngayNhap = dpNhap.Value.ToString("yyyy-MM-dd");
                    string ngayHetHan = dpOutDate.Value.ToString("yyyy-MM-dd");

                    con.Open();
                    // kiểm tra mã sản phẩm có tồn tại hay chưa 
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT count(MaSP)  FROM SANPHAM WHERE MaSP = @MaSp";
                    cmd.Parameters.AddWithValue("@MaSp", txt_MaSP.Text);
                    int soluong = (int)cmd.ExecuteScalar();
                    if (soluong > 0)
                    {
                        MessageBox.Show("Đã có sản phẩm này rồi ! \n Vui lòng nhập mã khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // kiểm tra tên nhà cung cấp có tồn tại hay chưa 
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT count(*) FROM NHACUNGCAP WHERE TenNCC = @TenNCC";
                    cmd.Parameters.AddWithValue("@TenNCC", cbb_TenNCC.Text);
                    int soluongNCC = (int)cmd.ExecuteScalar();
                    if (soluongNCC == 0)
                    {
                        MessageBox.Show("Chưa có nhà cung cấp sản phẩm này ! \n Vui lòng chọn nhà cung cấp khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // kiểm tra ngày nhập và ngày hết hạn
                    DateTime ngaynhap = dpNhap.Value;
                    DateTime ngayhethan = dpOutDate.Value;
                    if (ngaynhap > ngayhethan)
                    {
                        MessageBox.Show("Ngày bạn nhập sản phẩm không đúng ! \n Vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO SANPHAM VALUES (@MaSP, @TenSP, @DonVi, @SoLuongSP, @GiaBan, @GiaNhap, @MaNCC, @NgayNhap, @NgayHetHan)";
                    cmd.Parameters.AddWithValue("@MaSP", txt_MaSP.Text);
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSp.Text);
                    cmd.Parameters.AddWithValue("@DonVi", cbDonVi.Text);
                    cmd.Parameters.AddWithValue("@SoLuongSP", nb_soluong.Text);
                    cmd.Parameters.AddWithValue("@GiaBan", decimal.Parse(txtGiaBan.Text));
                    cmd.Parameters.AddWithValue("@GiaNhap", decimal.Parse(txtGiaNhap.Text));
                    cmd.Parameters.AddWithValue("@MaNCC", cbb_TenNCC.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                    cmd.Parameters.AddWithValue("@NgayHetHan", ngayHetHan);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sản phẩm thành công !");
                    ShowSanPham("SELECT * FROM SANPHAM");
                    cleartxt();
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra,\nVui lòng thử lại!");
            }
            finally
            {
                con.Close();
            }
        }

        // Xoa cac textbox
        public void cleartxt()
        {
           
            txtTenSp.Text = "";
            cbDonVi.Text = "";
            nb_soluong.Value = 0;
            txtGiaBan.Text = "0";
            txtGiaNhap.Text = "0";
            cbb_TenNCC.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string ngayNhap = dpNhap.Value.ToString("yyyy-MM-dd");
                string ngayHetHan = dpOutDate.Value.ToString("yyyy-MM-dd");
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE SANPHAM SET TenSP = @TenSP, DonVi = @DonVi, SoLuongSP = @SoLuongSP, GiaBan = @GiaBan, GiaNhap = @GiaNhap, MaNCC = @MaNCC, NgayNhap = @NgayNhap, NgayHetHan = @NgayHetHan WHERE MaSP = @MaSP";
                cmd.Parameters.AddWithValue("@MaSP", txt_MaSP.Text);
                cmd.Parameters.AddWithValue("@TenSP", txtTenSp.Text);
                cmd.Parameters.AddWithValue("@DonVi", cbDonVi.Text);
                cmd.Parameters.AddWithValue("@SoLuongSP", nb_soluong.Text);
                cmd.Parameters.AddWithValue("@GiaBan", decimal.Parse(txtGiaBan.Text));
                cmd.Parameters.AddWithValue("@GiaNhap", decimal.Parse(txtGiaNhap.Text));
                cmd.Parameters.AddWithValue("@MaNCC", cbb_TenNCC.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                cmd.Parameters.AddWithValue("@NgayHetHan", ngayHetHan);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa sản phẩm thành công!");
                ShowSanPham("SELECT * FROM SANPHAM");
                cleartxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM SANPHAM WHERE MaSP = @MaSP";
                cmd.Parameters.AddWithValue("@MaSP", txt_MaSP.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa sản phẩm thành công!");
                ShowSanPham("SELECT * FROM SANPHAM");
                cleartxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dtgSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgSanpham.MultiSelect = true;
            int i;
            i = dtgSanpham.CurrentRow.Index;
            txt_MaSP.Text = dtgSanpham.Rows[i].Cells[0].Value.ToString();
            txtTenSp.Text = dtgSanpham.Rows[i].Cells[1].Value.ToString();
            nb_soluong.Text = dtgSanpham.Rows[i].Cells[3].Value.ToString();
            cbDonVi.Text = dtgSanpham.Rows[i].Cells[2].Value.ToString();
            txtGiaBan.Text = dtgSanpham.Rows[i].Cells[4].Value.ToString();
            txtGiaNhap.Text = dtgSanpham.Rows[i].Cells[5].Value.ToString();
            dpNhap.Text = dtgSanpham.Rows[i].Cells[7].Value.ToString();
            dpOutDate.Text = dtgSanpham.Rows[i].Cells[8].Value.ToString();
            cbb_TenNCC.Text = dtgSanpham.Rows[i].Cells[6].Value.ToString();
        }

        public void NhacNho()
        {
            try
            {
                con.Open();
                string query = "SELECT TenSP,NgayHetHan FROM SANPHAM WHERE NgayHetHan<=@Today";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    string message = "";
                    while (reader.Read())
                    {
                        string TenSP = reader["TenSP"].ToString();
                        DateTime NgayHetHan = DateTime.Now;
                        message += $"Sản phẩm {TenSP} đã hết hạn \n Bạn có thể bỏ loại trái cây này !\n";

                    }
                    if (!string.IsNullOrEmpty(message))
                    {
                        MessageBox.Show(message, "Thông Báo Nhắc Nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Có lỗi xảy ra " + ex.Message);
            }
        }

        private void picTroVe_Click(object sender, EventArgs e)
        {
            frmQuanLy vequanlytusanpham = new frmQuanLy();
            vequanlytusanpham.Show();
            this.Close();
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhapsanpham = new frmDangNhap();
            dangnhapsanpham.Show();
            this.Close();
        }
        public void TangMaSP()
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT MAX(MaSP) FROM SANPHAM";
                object kq = cmd.ExecuteScalar();
                int masp = 0;
                if (kq != null)
                {
                    masp = int.Parse(kq.ToString().Substring(1)); // Lấy phần số sau 'S'
                }
                masp++;
                txt_MaSP.Text = "S" + masp.ToString(); // Thêm 'S' vào trước số
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ShowSanPham("SELECT * FROM SANPHAM WHERE MaSP LIKE '%" + txtTimKiem.Text.Trim() + "%' OR TenSP LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
        }
    }
}
