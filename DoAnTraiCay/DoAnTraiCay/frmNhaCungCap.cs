using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTraiCay
{
    public partial class frmNhaCungCap : Form
    {
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\DoAnTraiCay\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public frmNhaCungCap()
        {
            InitializeComponent();
            con = new SqlConnection(connectstring);

        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            TangMaNCC();
            // TODO: This line of code loads data into the 'qLCHTraiCayDataSet31.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter8.Fill(this.qLCHTraiCayDataSet31.NHACUNGCAP);



            try
            {
                con.Open();
                // Lấy dữ liệu mới từ cơ sở dữ liệu
                cmd = new SqlCommand("SELECT * FROM NHACUNGCAP", con);

                adt = new SqlDataAdapter(cmd);
                dt.Clear(); // Xóa dữ liệu cũ trong DataTable
                adt.Fill(dt); // Lấy dữ liệu mới từ cơ sở dữ liệu
                dtgNhaCC.DataSource = dt; // Cập nhật lại DataSource của DataGridView

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra" + ex.Message);

            }
            finally
            {
                con.Close();
            }
            NhacNho();

        }

        public void TangMaNCC()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT MAX(MaNCC) FROM NHACUNGCAP";
                    object kq = cmd.ExecuteScalar();
                    int mancc = 0;
                    if (kq != null)
                    {
                        mancc = int.Parse(kq.ToString());
                    }
                    mancc++;
                    txt_MaNCC.Text = mancc.ToString();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void picTroVe_Click(object sender, EventArgs e)
        {
            frmQuanLy trovethui = new frmQuanLy();
            trovethui.Show();
            this.Close();
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhapthoai = new frmDangNhap();
            dangnhapthoai.Show();
            this.Close();
        }
        private void ShowNhaCungCap(string query)
        {
            try
            {
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear(); // Xóa dữ liệu cũ
                adt.Fill(dt);
                dtgNhaCC.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
       public void cleartxt()
        {
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            txt_DiaChi.Clear();
            txt_Email.Clear();
            txt_SDT.Clear();
            
        }
        private void picThemNCC_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_MaNCC.Text)&& !string.IsNullOrEmpty(txt_TenNCC.Text)&& !string.IsNullOrEmpty(txt_DiaChi.Text)&& !string.IsNullOrEmpty(txt_Email.Text)&& !string.IsNullOrEmpty(txt_SDT.Text))
                {
                    // kiểm tra số điện thoại phải là 10 số 
                    string sdt = txt_SDT.Text;
                    if (sdt.Length > 10)
                    {
                        MessageBox.Show("Số điện thoại phải có 10 số! ");
                        return;
                    }
                    if (sdt.Any(char.IsLetter))
                    {
                        MessageBox.Show("Số điện thoại không được chứa ký tự chữ!");
                        return;
                    }
                    using (SqlConnection con = new SqlConnection(connectstring))
                        {
                            con.Open();
                            // kiểm tra xem đã có nhà cung cấp chưa
                            cmd = con.CreateCommand();
                            cmd.CommandText = "SELECT count(MaNCC)  FROM  NHACUNGCAP  WHERE  MaNCC = @MaNCC";
                            cmd.Parameters.AddWithValue("@MaNCC", txt_MaNCC.Text);
                            int soluongNCC = (int)cmd.ExecuteScalar();
                            if (soluongNCC > 0)
                            {
                                MessageBox.Show("Đã có nhà cung cấp sản phẩm này ! \n Vui lòng nhập mã khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            DateTime ngaykyhd = dp_NgayDK.Value;
                            DateTime ngayhethd = dp_NgayHetHan.Value;
                            if (ngaykyhd > ngayhethd)
                            {
                                MessageBox.Show("Ngày bạn ký hợp đồng không đúng ! \n Vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            cmd = con.CreateCommand();
                            cmd.CommandText = "SELECT count(SoDienThoai)  FROM  NHACUNGCAP  WHERE  SoDienThoai = @sdt";
                            cmd.Parameters.AddWithValue("@sdt", txt_SDT.Text);
                            int sodienthoai = (int)cmd.ExecuteScalar();
                            if (sodienthoai > 0)
                            {
                                MessageBox.Show("Đã có số điện thoại này ! \n Vui lòng nhập số điện thoại khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            cmd = con.CreateCommand();
                            cmd.CommandText = "SELECT count(Email)  FROM  NHACUNGCAP  WHERE  Email = @email";
                            cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                            int email = (int)cmd.ExecuteScalar();
                            if (email > 0)
                            {
                                MessageBox.Show("Đã có email này ! \n Vui lòng nhập email khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string ngaydangky = dp_NgayDK.Value.ToString("yyyy-MM-dd");
                                string ngayhethan = dp_NgayHetHan.Value.ToString("yyyy-MM-dd");

                                cmd = con.CreateCommand();
                                cmd.CommandText = "INSERT INTO NHACUNGCAP VALUES (@MaNCC, @TenNCC, @DiaChi, @SoDienThoai, @Email,@NgayDK,@NgayHetHan)";
                                cmd.Parameters.AddWithValue("@MaNCC", txt_MaNCC.Text);
                                cmd.Parameters.AddWithValue("@TenNCC", txt_TenNCC.Text);
                                cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text);
                                cmd.Parameters.AddWithValue("@SoDienThoai", txt_SDT.Text);
                                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                                cmd.Parameters.AddWithValue("@NgayDK", ngaydangky);
                                cmd.Parameters.AddWithValue("@NgayHetHan", ngayhethan);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm nhà cung cấp thành công !");
                                ShowNhaCungCap("SELECT * FROM NHACUNGCAP");
                                cleartxt();
                            }
                        
                    }    
                    
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại! " + ex.Message);
            }
            
        }

        private void picSuaNCC_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNCC.Text) || string.IsNullOrEmpty(txt_TenNCC.Text) ||
                string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_Email.Text) ||
                string.IsNullOrEmpty(txt_SDT.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // kiểm tra số điện thoại phải là 10 số 
            string sdt = txt_SDT.Text;
            if (sdt.Length > 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 số! ");
                return;
            }
            if (sdt.Any(char.IsLetter))
            {
                MessageBox.Show("Số điện thoại không được chứa ký tự chữ!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    string ngaydangky = dp_NgayDK.Value.ToString("yyyy-MM-dd");
                    string ngayhethan = dp_NgayHetHan.Value.ToString("yyyy-MM-dd");
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE NHACUNGCAP SET TenNCC = @TenNCC, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Email = @Email,NgayKyHD=@ngaykyhd,NgayHetHanHD=@ngayhethd WHERE MaNCC = @MaNCC", con))
                    {
                        cmd.Parameters.AddWithValue("@MaNCC", txt_MaNCC.Text);
                        cmd.Parameters.AddWithValue("@TenNCC", txt_TenNCC.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", txt_SDT.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                        cmd.Parameters.AddWithValue("@ngaykyhd", ngaydangky);
                        cmd.Parameters.AddWithValue("@ngayhethd", ngayhethan);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa thành công!");
                            ShowNhaCungCap("SELECT * FROM NHACUNGCAP");
                            cleartxt();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhà cung cấp để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void picXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_MaNCC.Text) && !string.IsNullOrEmpty(txt_TenNCC.Text) && !string.IsNullOrEmpty(txt_DiaChi.Text) && !string.IsNullOrEmpty(txt_Email.Text) && !string.IsNullOrEmpty(txt_SDT.Text))
                {
                    using (SqlConnection con = new SqlConnection(connectstring))
                    {
                        con.Open();
                        cmd = con.CreateCommand();

                        cmd.CommandText = "delete from SANPHAM where MaNCC = '" + txt_MaNCC.Text + "'";

                        cmd.ExecuteNonQuery();
                        SqlCommand cmdDeleteInvoice = con.CreateCommand();
                        cmdDeleteInvoice.CommandText = "DELETE FROM NHACUNGCAP WHERE MaNCC = @MaNCC";
                        cmdDeleteInvoice.Parameters.AddWithValue("@MaNCC", txt_MaNCC.Text);
                        cmdDeleteInvoice.ExecuteNonQuery();

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        ShowNhaCungCap("SELECT * FROM NHACUNGCAP");

                        // Cập nhật lại DataGridView
                        dtgNhaCC.Refresh();
                        cleartxt();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }




        private void xoaSP()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM SANPHAM WHERE MaNCC = @MaNCC";
                cmd.Parameters.AddWithValue("@MaNCC", txt_MaNCC.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa sản phẩm của nhà cung cấp thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void txtTKNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            ShowNhaCungCap("SELECT * FROM NHACUNGCAP WHERE MaNCC LIKE '%" + txtTKNhaCungCap.Text.Trim() + "%' OR TenNCC LIKE  N'%" + txtTKNhaCungCap.Text.Trim() + "%' ");
        }
        public void NhacNho()
        {
            try
            {
                con.Open();
                string query = "SELECT  TenNCC,NgayHetHanHD FROM NHACUNGCAP WHERE NgayHetHanHD<=@Today";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    string message = "";
                    while (reader.Read())
                    {
                        string TenNCC = reader["TenNCC"].ToString();
                        DateTime NgayHetHan = DateTime.Now;
                        message += $"Nhà cung cấp tên {TenNCC}có hợp đồng đã hết hạn \n Bạn có thể kết thúc hợp đồng hoặc gia hạn !\n";

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

        private void dtgNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgNhaCC.MultiSelect = true;
            int i;
            i = dtgNhaCC.CurrentRow.Index;
            txt_MaNCC.Text = dtgNhaCC.Rows[i].Cells[0].Value.ToString();
            txt_TenNCC.Text = dtgNhaCC.Rows[i].Cells[1].Value.ToString();
            txt_DiaChi.Text = dtgNhaCC.Rows[i].Cells[2].Value.ToString();
            txt_SDT.Text = dtgNhaCC.Rows[i].Cells[3].Value.ToString();
            txt_Email.Text = dtgNhaCC.Rows[i].Cells[4].Value.ToString();
            dp_NgayDK.Text= dtgNhaCC.Rows[i].Cells[5].Value.ToString();
            dp_NgayHetHan.Text = dtgNhaCC.Rows[i].Cells[6].Value.ToString();

        }
        public bool KTSDT()
        {
            string sdt = txt_SDT.Text;
            Regex rg = new Regex(@"^\d+$");
            Match match = rg.Match(sdt);
            if (!match.Success)
            {
                MessageBox.Show("Số điện thoại phải là chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        
    }
}
