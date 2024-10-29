using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTraiCay
{
    public partial class frmDangNhap : Form
    {
        // cái string conection này nhấp vào properties của database và cop trong đó ra nhé
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\DoAnTraiCay\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";

        public frmDangNhap()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
       
        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TAIKHOAN = txtDangNhap.Text;
            string MATKHAU = txtMatKhau.Text;
            string VAITRO = "";
            // này demo nha, sau khi kiểm tra thông tin đăng nhập trùng khớp thì báo thành công và
            //nhảy đến trang homepage để tiếp tục các thao tác khác.
            if (CheckLogin(TAIKHOAN, MATKHAU,out VAITRO))
            {
                if (VAITRO == "Admin")
                {
                    // Chuyển người dùng với vai trò admin đến form quản lý
                    frmQuanLy quanLyForm = new frmQuanLy();
                    quanLyForm.Show();
                    MessageBox.Show("Đăng nhập thành công !\nBạn đang đăng nhập với quyền quản trị viên !","Thông báo");
                    this.Hide();
                }
                else if(VAITRO =="NhanVien")
                {
                    frmHomePage homePage = new frmHomePage();// tao tạo 1 cái form khac tên là frmHomePage
                    homePage.Show();//Hiện trang homepage
                    this.Hide();//ẩn trang đăng nhập hiện tại
                    MessageBox.Show("Đăng nhập thành công !\nBạn đang đăng nhập với quyền là nhân viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            else if (string.IsNullOrEmpty(txtDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                //khúc if else này kiểm tra nếu 1 trong 2 ô thong tin tk trống thì hiện tbao nha
                MessageBox.Show("Vui lòng điền đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // cái này thì là nếu như nhập sai sẽ hiện thong báo và reset ô nhập thành khoảng trắng
                //bắt nhập lại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu đã sai, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDangNhap.Text = "";
                txtMatKhau.Text = "";
            }
             
        }

    
        private bool CheckLogin(string TAIKHOAN, string MATKHAU, out string VAITRO)//ham kiem tra dang nhap
        {

            VAITRO = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1),VAITRO FROM TAIKHOANNV WHERE TAIKHOAN = @Username AND MATKHAU = @Password GROUP BY VaiTro";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", TAIKHOAN);
                    command.Parameters.AddWithValue("@Password", MATKHAU);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        VAITRO = reader.GetString(1); // Đọc giá trị từ cột VAITRO dưới dạng chuỗi
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
        
            }
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0'; // Ký tự null để hiển thị mật khẩu
            }
            else
            {
                txtMatKhau.PasswordChar = '*'; // Ký tự '' để ẩn mật khẩu
            }
        }

        private void btnThoatDN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               btnDangNhap_Click(this, new EventArgs());
            }
        }
    }
    
}

