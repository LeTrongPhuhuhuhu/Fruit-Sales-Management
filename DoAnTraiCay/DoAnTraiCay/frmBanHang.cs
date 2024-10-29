using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace DoAnTraiCay
{
    public partial class frmBanHang : Form
    {
        
        float Tongtien = 0;
        float Tongsoluong = 0;
        string HoaDon = "";
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\DoAnTraiCay\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public frmBanHang()
        {
            InitializeComponent();

            con = new SqlConnection(connectstring);

        }


        private void ShowSanPham(string query)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                dtgSPBH.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private void ShowHoaDon(string hquery)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(hquery, con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                dtgHoaDon.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
           
            try
            {
                float gia = float.Parse(txtGiaBH.Text);
                int soluong = int.Parse(txtSoLuongBH.Text);
                float tongtien = soluong * gia;
                txtTongTienBH.Text = tongtien.ToString();
               
               
                if (string.IsNullOrEmpty(txtSoLuongBH.Text)&&!int.TryParse(txtSoLuongBH.Text, out soluong))
                {
                    MessageBox.Show("Số lượng không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra số lượng sản phẩm có đủ không
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    
                    cmd.CommandText = "SELECT SoLuongSP FROM SANPHAM WHERE MaSP = @MaSP";
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSPBH.Text);
                    int soLuongHienCo = (int)cmd.ExecuteScalar();

                    int soLuongBan = int.Parse(txtSoLuongBH.Text); // Số lượng sản phẩm khách hàng muốn mua

                    // Kiểm tra xem số lượng hiện có có đủ để bán không
                    if (soLuongHienCo >= soLuongBan)
                    {
                        // Kiểm tra xem mã sản phẩm đã tồn tại chưa
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM CT_SANPHAM WHERE MaSP = @MaSP", con);
                        cmdCheck.Parameters.AddWithValue("@MaSP", txtMaSPBH.Text);
                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Tiến hành thêm sản phẩm vào hóa đơn
                            cmd.CommandText = "INSERT INTO CT_SANPHAM (MaSP, TenSP, DonVi, GiaBan, SoLuongSP) VALUES (@MaSP, @TenSP, @DonVi, @GiaBan, @SoLuongSP)";
                            cmd.Parameters.AddWithValue("@TenSP", txtTenSPBH.Text);
                            cmd.Parameters.AddWithValue("@DonVi", cbDVT.Text);
                            cmd.Parameters.AddWithValue("@GiaBan", gia);
                            cmd.Parameters.AddWithValue("@SoLuongSP", soluong);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Đã thêm sản phẩm của khách thành công!");

                            // Cập nhật tổng tiền và tổng số lượng
                            Tongtien += tongtien;
                            Tongsoluong += soluong;
                            txtTongTienBH.Text = Tongtien.ToString();
                            txtTongSoLuong.Text = Tongsoluong.ToString();

                            // Cập nhật lại DataGridView
                            ShowHoaDon("SELECT * FROM CT_SANPHAM");
                            dtgHoaDon.Refresh();
                            XoaDuLieutextbox();
                        }
                       

                    }
                    else
                    {
                        MessageBox.Show("Không đủ số lượng trong kho. Không thể thêm sản phẩm vào hóa đơn.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message);
            }
        }

        // hàm xóa dữ liệu text box
        public void XoaDuLieutextbox()
        {
            txtMaSPBH.Text = "";
            txtTenSPBH.Text = "";
            txtGiaBH.Text = "";
            txtSoLuongBH.Text = "";
        }
        private void UpdateSP() // hàm update dtgSPBH
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();

                    foreach (DataGridViewRow row in dtgHoaDon.Rows)// duyệt từng dòng trong dtgHoaDon nha
                    {
                        if (row != null && row.Cells != null)// Kiểm tra các dòng vaf cột trong dtgHoaDon
                        {
                            string maSP = row.Cells["MaSP"].Value?.ToString();// lấy giá trị từ cột MaSp
                            string soLuongSP = row.Cells["SoLuongSP"].Value?.ToString();// lấy giá trị từ cột SoLuongSP

                            if (!string.IsNullOrEmpty(maSP) && !string.IsNullOrEmpty(soLuongSP))
                            {
                                // Cập nhật số lượng sản phẩm
                                cmd.CommandText = "UPDATE SANPHAM SET SoLuongSP = SoLuongSP - @SoLuongSP WHERE MaSP = @MaSP";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@MaSP", maSP);
                                cmd.Parameters.AddWithValue("@SoLuongSP", soLuongSP);

                                cmd.ExecuteNonQuery();
                                ShowSanPham("SELECT*FROM SANPHAM");
                                dtgHoaDon.Refresh();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }







        private void frmBanHang_Load_1(object sender, EventArgs e)
        {
            TangMaHD();
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    // Lấy dữ liệu mới từ cơ sở dữ liệu
                    cmd = new SqlCommand("SELECT * FROM SANPHAM", con);
                    adt = new SqlDataAdapter(cmd);
                    dt.Clear(); // Xóa dữ liệu cũ trong DataTable
                    adt.Fill(dt); // Lấy dữ liệu mới từ cơ sở dữ liệu
                    dtgSPBH.DataSource = dt; // Cập nhật lại DataSource của DataGridView

                    // Cập nhật lại DataGridView dtgHoaDon
                    ShowSanPham("SELECT * FROM SANPHAM");
                    dtgSPBH.Refresh();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            HienDS();
        }





        private void picTroVe_Click(object sender, EventArgs e)
        {

            frmHomePage trovenheem = new frmHomePage();
            trovenheem.Show();
            this.Close();

        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap backtodangnhap = new frmDangNhap();
            backtodangnhap.Show();
            this.Close();
        }

        private void picKH_Click(object sender, EventArgs e)
        {
            frmKhachHang khtt = new frmKhachHang("NhanVien");
            khtt.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (cbLoc.Text == "Mã SP")
            {
                ShowSanPham("SELECT * FROM SANPHAM WHERE MaSP LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbLoc.Text == "Tên SP")
            {
                ShowSanPham("SELECT * FROM SANPHAM WHERE TenSP LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbLoc.Text == "Mã SP")
            {
                ShowSanPham("SELECT * FROM SANPHAM WHERE MaSP LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbLoc.Text == "Tên SP")
            {
                ShowSanPham("SELECT * FROM SANPHAM WHERE TenSP LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
        }






        private void picXoa_Click(object sender, EventArgs e)
        {
            float gia;
            if (!float.TryParse(txtGiaBH.Text, out gia))
            {
                MessageBox.Show("Giá không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soluong = int.Parse(txtSoLuongBH.Text);
            float tongtien = soluong * gia;
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "delete from CT_SANPHAM where MaSP = '" + txtMaSPBH.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    ShowHoaDon("select * from CT_SANPHAM");
                    // Cập nhật lại DataGridView
                    dtgHoaDon.Refresh();
                    CapNhatTongTienVaSoLuong();
                    XoaDuLieutextbox();
                }
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

        public void TongTien()
        {


        }

        private void frmBanHang_FormClosed(object sender, FormClosedEventArgs e)
        { //Reset giỏ hàng nếu như bấm trở về  hoặc đóng form giữa chừng
            using (SqlConnection con = new SqlConnection(connectstring))
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from CT_SANPHAM ";
                cmd.ExecuteNonQuery();

                ShowHoaDon("select * from CT_SANPHAM");
                // Cập nhật lại DataGridView
                dtgHoaDon.Refresh();
            }

        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();

                    // Kiểm tra mã hóa đơn đã tồn tại chưa
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM HOADON WHERE Mahd = @MaHd", con))
                    {
                        cmd.Parameters.AddWithValue("@MaHd", txtMaHoaDon.Text);
                        int count = (int)cmd.ExecuteScalar();

                        // Nếu mã hóa đơn đã tồn tại, thông báo và kết thúc
                        if (count > 0)
                        {
                            MessageBox.Show("Mã hóa đơn đã tồn tại. Vui lòng chọn mã hóa đơn khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Nếu mã hóa đơn không được nhập, thông báo và kết thúc
                        if (string.IsNullOrEmpty(txtMaHoaDon.Text))
                        {
                            MessageBox.Show("Vui lòng nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Thêm hóa đơn và chi tiết hóa đơn vào cơ sở dữ liệu
                        AddHoaDon();
                        AddCT_HoaDon();

                        // Tạo hóa đơn và hiển thị thông tin
                        StringBuilder hoaDon = new StringBuilder();
                        hoaDon.AppendLine("                                 HÓA ĐƠN THANH TOÁN                               ");
                        hoaDon.AppendLine($"Ngày lập hóa đơn: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");

                        float tongTienHoaDon = 0;
                        int tongSoLuongSPHoaDon = 0;

                        if (dtgHoaDon.Rows != null && dtgHoaDon.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow row in dtgHoaDon.Rows)
                            {
                                if (row != null && row.Cells != null)
                                {
                                    string maSP = row.Cells["MaSP"].Value?.ToString();
                                    string tenSP = row.Cells["TenSP"].Value?.ToString();
                                    string giaBan = row.Cells["GiaBan"].Value?.ToString();
                                    string soLuongSP = row.Cells["SoLuongSP"].Value?.ToString();
                                    if (maSP != null && tenSP != null && giaBan != null && soLuongSP != null)
                                    {

                                        float tongTienSP = int.Parse(soLuongSP) * float.Parse(giaBan);

                                        hoaDon.AppendLine($"\nMã SP: {maSP},\tTên SP: {tenSP},    Số lượng: {soLuongSP}");
                                        hoaDon.AppendLine($"Giá bán: {giaBan}, \t\tTổng tiền của sản phẩm: {tongTienSP}");
                                        hoaDon.AppendLine("---------------------------------------------------------------------------");

                                        tongTienHoaDon += tongTienSP;
                                        tongSoLuongSPHoaDon += int.Parse(soLuongSP);
                                    }
                                   
                                }
                            }

                            hoaDon.AppendLine($"\t\tTổng số lượng sản phẩm của hóa đơn: {tongSoLuongSPHoaDon}");
                            hoaDon.AppendLine($"\t\tTổng tiền của hóa đơn: {tongTienHoaDon}");

                            MessageBox.Show(hoaDon.ToString(), "Hóa đơn thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateSP();
                        }
                        else
                        {
                            MessageBox.Show("Không có sản phẩm nào trong hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void picSua_Click(object sender, EventArgs e)
        {
            float gia = float.Parse(txtGiaBH.Text);
            int soluong = int.Parse(txtSoLuongBH.Text);
            float tongtien = soluong * gia;
            txtTongTienBH.Text = tongtien.ToString();

            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE CT_SANPHAM SET SoLuongSP = @SoLuongSP WHERE MaSP = @MaSP";
                    cmd.Parameters.AddWithValue("@SoLuongSP", txtSoLuongBH.Text);
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSPBH.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!");

                    // Cập nhật DataGridView và tính lại tổng tiền và tổng số lượng
                    ShowHoaDon("select * from CT_SANPHAM");
                    dtgHoaDon.Refresh();
                    CapNhatTongTienVaSoLuong();
                    XoaDuLieutextbox();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        private void btnThanhToanVaInHoaDon_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectstring))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM HOADON WHERE Mahd = @MaHd";
                cmd.Parameters.AddWithValue("@MaHd", txtMaHoaDon.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại. Vui lòng chọn mã hóa đơn khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                else
                {
                    AddHoaDon();
                    AddCT_HoaDon();
                    frmBill bill = new frmBill();
                    bill.ShowDialog();
                }

            }


        }
        public void AddCT_HoaDon()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();

                    foreach (DataGridViewRow row in dtgHoaDon.Rows)
                    {
                        // Kiểm tra giá trị của cell trước khi sử dụng
                        if (row.Cells["MaSP"].Value != null && row.Cells["TenSP"].Value != null
                            && row.Cells["DonVi"].Value != null && row.Cells["GiaBan"].Value != null
                            && row.Cells["SoLuongSP"].Value != null)
                        {
                            // Lấy giá trị từ các cell
                            string maSP = row.Cells["MaSP"].Value.ToString();
                            string tenSP = row.Cells["TenSP"].Value.ToString();
                            string dvt = row.Cells["DonVi"].Value.ToString();
                            decimal giaBan = decimal.Parse(row.Cells["GiaBan"].Value.ToString());
                            int soLuong = int.Parse(row.Cells["SoLuongSP"].Value.ToString());



                            float thanhTien = (float)(giaBan * soLuong);


                            // Thêm thông tin vào bảng CT_HOADON
                            cmd.CommandText = "INSERT INTO CT_HOADON (MaHd, MaSp, TenSp, Dvt, GiaBan, SoLuong, ThanhTien) VALUES (@MaHd, @MaSp, @TenSp, @Dvt, @GiaBan, @SoLuong, @ThanhTien)";
                            cmd.Parameters.AddWithValue("@MaHd", txtMaHoaDon.Text);
                            cmd.Parameters.AddWithValue("@MaSp", maSP);
                            cmd.Parameters.AddWithValue("@TenSp", tenSP);
                            cmd.Parameters.AddWithValue("@Dvt", dvt);
                            cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }


                        //MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công!");
                        dtgHoaDon.Refresh();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        public void AddHoaDon()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                   

                    {
                        // Lấy tên khách hàng từ dtgKhachHang
                        string maKhachHang = cbMaKH.SelectedValue.ToString();
                        string tenKhachHang = laytenKH(maKhachHang);

                        // Thêm hóa đơn với tên khách hàng vào cơ sở dữ liệu
                        cmd.CommandText = "INSERT INTO HOADON (Mahd, NgayTao, TenKhachHang) VALUES (@MaHd, @NgayTao, @TenKhachHang)";
                        cmd.Parameters.Clear(); // Xóa bỏ các tham số trước đó
                        cmd.Parameters.AddWithValue("@MaHd", txtMaHoaDon.Text);
                        cmd.Parameters.AddWithValue("@NgayTao", DateTime.Now);
                        cmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đã thêm hóa đơn thành công!");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        public string laytenKH(string makh)
        {
            string tenKhachHang = "";
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT HoKh+' '+TenKh as hoten  FROM KHACHHANG WHERE MaKh=@MaKh";
                    cmd.Parameters.AddWithValue("@MaKh", makh);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        tenKhachHang = reader["hoten"].ToString();
                    }
                    //MessageBox.Show("Lấy tên khách hàng thành công!");
                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return tenKhachHang;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dtgSPBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgSPBH.MultiSelect = true;
            int i;
            i = dtgSPBH.CurrentRow.Index;
            txtMaSPBH.Text = dtgSPBH.Rows[i].Cells[0].Value.ToString();
            txtTenSPBH.Text = dtgSPBH.Rows[i].Cells[1].Value.ToString();
            cbDVT.Text = dtgSPBH.Rows[i].Cells[2].Value.ToString();
            txtGiaBH.Text = dtgSPBH.Rows[i].Cells[3].Value.ToString();
        }
        private void HienDS()
        {
            string sSql;
            sSql = "SELECT MaKh, TenKh+' '+HoKh+' '+MaKh as ten  FROM KHACHHANG";
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sSql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                cbMaKH.DataSource = ds.Tables[0];
                cbMaKH.DisplayMember = "ten";
                cbMaKH.ValueMember = "MaKh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI. Chi tiet: " + ex.Message);
            }
        }

        private void dtgHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgHoaDon.MultiSelect = true;
            int i;
            i = dtgHoaDon.CurrentRow.Index;
            txtMaSPBH.Text = dtgHoaDon.Rows[i].Cells[0].Value.ToString();
            txtTenSPBH.Text = dtgHoaDon.Rows[i].Cells[1].Value.ToString();
            cbDVT.Text = dtgHoaDon.Rows[i].Cells[2].Value.ToString();
            txtGiaBH.Text = dtgHoaDon.Rows[i].Cells[4].Value.ToString();
            txtSoLuongBH.Text = dtgHoaDon.Rows[i].Cells[3].Value.ToString();
         
        }
        public void TangMaHD()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT MAX(Mahd) FROM HOADON";
                    object kq = cmd.ExecuteScalar();
                    int MaHd = 0;
                    if(kq != null)
                    {
                        MaHd=int.Parse(kq.ToString());
                    }
                    MaHd++;
                    txtMaHoaDon.Text = MaHd.ToString();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CapNhatTongTienVaSoLuong()
        {
            float tongTien = 0;
            int tongSoLuong = 0;

            foreach (DataGridViewRow row in dtgHoaDon.Rows)
            {
                if (row.Cells["GiaBan"].Value != null && row.Cells["SoLuongSP"].Value != null)
                {
                    float giaBan = float.Parse(row.Cells["GiaBan"].Value.ToString());
                    int soLuongSP = int.Parse(row.Cells["SoLuongSP"].Value.ToString());

                    tongTien += giaBan * soLuongSP;
                    tongSoLuong += soLuongSP;
                }
            }

            txtTongTienBH.Text = tongTien.ToString();
            txtTongSoLuong.Text = tongSoLuong.ToString();
        }




    }





}