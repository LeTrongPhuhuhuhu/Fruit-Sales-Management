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
    public partial class frmKhachHang_QL : Form
    {
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public frmKhachHang_QL()
        {
            InitializeComponent();
            con = new SqlConnection(connectstring);
        }

        private void frmKhachHang_NV_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // Lấy dữ liệu mới từ cơ sở dữ liệu
                cmd = new SqlCommand("SELECT * FROM KHACHHANG", con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear(); // Xóa dữ liệu cũ trong DataTable
                adt.Fill(dt); // Lấy dữ liệu mới từ cơ sở dữ liệu
                dtgKhachHang.DataSource = dt; // Cập nhật lại DataSource của DataGridView

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra" + ex.Message);

            }
            finally
            {
                con.Close();
            }

        }

        private void picTroVe_Click(object sender, EventArgs e)
        {
            frmQuanLy quanly = new frmQuanLy();
            quanly.Show();
            this.Close();
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
            this.Close();
        }
    }
}
