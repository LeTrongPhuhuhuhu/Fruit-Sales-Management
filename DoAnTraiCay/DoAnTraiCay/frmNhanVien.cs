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
using System.Collections;
using CrystalDecisions.ReportAppServer.CommonControls;
using System.Text.RegularExpressions;


namespace DoAnTraiCay
{
    public partial class frmNhanVien : Form
    { // khai báo biến toàn cục để kết nối SqlServer 
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\DoAnTraiCay\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        
        public frmNhanVien()
        {
            InitializeComponent();
             con = new SqlConnection(connectstring);
           

        }

       
       
// form load khi mới mở ứng dungj lên 
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            TangMaNV();
            try
            {
                con.Open();
                ShowNhanVien("select * from NHANVIEN");
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
// Chức năng tăng mã nhân viên tự động 
        public void TangMaNV()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT MAX(MaNv) FROM NHANVIEN";
                    object kq = cmd.ExecuteScalar();
                    int MaNv = 0;
                    if (kq != null)
                    {
                        MaNv = int.Parse(kq.ToString());
                    }
                    MaNv++;
                    txtManv.Text = MaNv.ToString();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void ShowNhanVien(string query)
        {
            try
            {
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear(); // Xóa dữ liệu cũ
                adt.Fill(dt);
                dtgThongTin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

       
 // Nút thêm Nhân Viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtManv.Text) && !string.IsNullOrEmpty(txtHonv.Text) && !string.IsNullOrEmpty(txtLuong.Text) && !string.IsNullOrEmpty(txtDiachi.Text) && !string.IsNullOrEmpty(txtTennv.Text) && !string.IsNullOrEmpty(cbbGioiTinh.Text) && !string.IsNullOrEmpty(txtSdt.Text) && !string.IsNullOrEmpty(txtEmail.Text))
                {

                    {
                        using (SqlConnection con = new SqlConnection(connectstring))
                        {
                            con.Open();
                            cmd = con.CreateCommand();
                            cmd.CommandText = "SELECT count(MaNv)  FROM NHANVIEN WHERE MaNv = @MaNv";
                            cmd.Parameters.AddWithValue("@MaNv", txtManv.Text);
                            int soluongmanv = (int)cmd.ExecuteScalar();
                            if (soluongmanv > 0)
                            {
                                MessageBox.Show("Đã có mã nhân viên này rồi ! \n Vui lòng nhập mã khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            cmd.CommandText = "SELECT count(SoDienThoai)  FROM NHANVIEN WHERE SoDienThoai = @Sdt";
                            cmd.Parameters.AddWithValue("@Sdt", txtSdt.Text);
                            int soluongsdt = (int)cmd.ExecuteScalar();
                            if (soluongsdt > 0)
                            {
                                MessageBox.Show("Đã có số điện thoại này rồi ! \n Vui lòng nhập số khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            cmd.CommandText = "SELECT count(Email)  FROM NHANVIEN WHERE Email = @email";
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            int soluongemail = (int)cmd.ExecuteScalar();
                            if (soluongemail > 0)
                            {
                                MessageBox.Show("Đã có Email này rồi ! \n Vui lòng nhập Email khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            // kiểm tra số điện thoại 
                            string sdt = txtSdt.Text;
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

                            cmd.CommandText = "insert into NHANVIEN values('" + txtManv.Text + "',N'" + txtHonv.Text + "',N'" + txtTennv.Text + "',N'" + txtDiachi.Text + "',N'" + cbbGioiTinh.Text + "','" + txtSdt.Text + "',N'" + txtEmail.Text + "','" + txtLuong.Text + "')";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm nhân viên thành công !");
                            ShowNhanVien("select * from NHANVIEN");
                            dtgThongTin.Refresh();
                            cleartxt();

                        }
                    

                        }
                    }
                   
                
                else
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
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

// Nút sửa nhân viên     
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtManv.Text) && !string.IsNullOrEmpty(txtHonv.Text) && !string.IsNullOrEmpty(txtLuong.Text) && !string.IsNullOrEmpty(txtDiachi.Text) && !string.IsNullOrEmpty(txtTennv.Text) && !string.IsNullOrEmpty(cbbGioiTinh.Text) && !string.IsNullOrEmpty(txtSdt.Text) && !string.IsNullOrEmpty(txtEmail.Text))
                {
                    string sdt = txtSdt.Text;
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
                            
                            cmd = con.CreateCommand();
                            cmd.CommandText = "UPDATE NHANVIEN SET  HoNv = N'" + txtHonv.Text + "', TenNv = N'" + txtTennv.Text + "', DiaChi = N'" + txtDiachi.Text + "', GioiTinh = N'" + cbbGioiTinh.Text + "', SoDienThoai = '" + txtSdt.Text + "', Email = '" + txtEmail.Text + "', Luong = '" + txtLuong.Text + "' WHERE MaNv = '" + txtManv.Text + "'";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Sửa thành công!");
                            ShowNhanVien("select * from NHANVIEN");

                            // Cập nhật lại DataGridView
                            dtgThongTin.Refresh();
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
            finally
            {
                con.Close();
            }
        }
  // Nút xóa nhân viên      
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtManv.Text) && !string.IsNullOrEmpty(txtHonv.Text) && !string.IsNullOrEmpty(txtLuong.Text) && !string.IsNullOrEmpty(txtDiachi.Text) && !string.IsNullOrEmpty(txtTennv.Text) && !string.IsNullOrEmpty(cbbGioiTinh.Text) && !string.IsNullOrEmpty(txtSdt.Text) && !string.IsNullOrEmpty(txtEmail.Text))
                {
                    DialogResult result = MessageBox.Show("Nếu như xóa nhân viên này, đồng thời tài khoản cũng sẽ bị xóa. \n Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(connectstring))
                        {
                            con.Open();
                            cmd = con.CreateCommand();
                            cmd.CommandText = "delete from NHANVIEN where MaNv = '" + txtManv.Text + "'";
                            cmd.ExecuteNonQuery();
                            // Thêm dòng này để xóa tài khoản từ ThemTKNV có MaNv trùng với MaNv bị xóa
                            cmd.CommandText = "delete from TAIKHOANNV where MANV = '" + txtManv.Text + "'";
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Xóa thành công!");
                            ShowNhanVien("select * from NHANVIEN");

                            // Cập nhật lại DataGridView
                            dtgThongTin.Refresh();
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
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
// nhảy sang frmThemTKNV để tạo tài khoản nhân viên
        private void btnThemTKNV_Click(object sender, EventArgs e)
        {
            frmThemTKNV themtk = new frmThemTKNV();
            themtk.Show();
            this.Hide();
        }
// tìm kiếm nhân viên
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ShowNhanVien("SELECT * FROM NHANVIEN WHERE MaNv LIKE '%" + txtTimKiem.Text.Trim() + "%' OR HoNv LIKE N'%" + txtTimKiem.Text.Trim() + "%'  OR TenNv LIKE N'%" + txtTimKiem.Text.Trim() + "%' OR DiaChi LIKE '%" + txtTimKiem.Text.Trim() + "%'OR SoDienThoai LIKE '%" + txtTimKiem.Text.Trim() + "%'");
        }
        
 // click vào thì thông tin nhảy sang các textbox
        private void dtgThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgThongTin.MultiSelect = true;
            int i = dtgThongTin.CurrentRow.Index;
            txtManv.Text = dtgThongTin.Rows[i].Cells[0].Value.ToString();
            txtHonv.Text = dtgThongTin.Rows[i].Cells[1].Value.ToString();
            txtTennv.Text = dtgThongTin.Rows[i].Cells[2].Value.ToString();
            txtDiachi.Text = dtgThongTin.Rows[i].Cells[3].Value.ToString();
            cbbGioiTinh.Text = dtgThongTin.Rows[i].Cells[4].Value.ToString();
            txtSdt.Text = dtgThongTin.Rows[i].Cells[5].Value.ToString();
            txtEmail.Text = dtgThongTin.Rows[i].Cells[6].Value.ToString();
            txtLuong.Text = dtgThongTin.Rows[i].Cells[7].Value.ToString();
        }
// nút trở về
        private void picTroVe_Click(object sender, EventArgs e)
        {
            frmQuanLy quanLy = new frmQuanLy();
            quanLy.Show();
            this.Close();
        }
        // nút đăng xuất 
        private void picDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.Show();
            this.Hide();
        }
 // Chức năng xóa các thông tin khi thêm, sửa , xóa
        public void cleartxt()
        {
            txtManv.Clear();
            txtHonv.Clear();
            txtTennv.Clear();
            txtDiachi.Clear();
            txtLuong.Clear();
            txtSdt.Clear();
            txtEmail.Clear();
        }

       
    }
}
