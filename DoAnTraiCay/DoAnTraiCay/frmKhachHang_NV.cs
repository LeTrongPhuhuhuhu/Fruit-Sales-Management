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
    public partial class frmKhachHang_NV : Form
    {
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public frmKhachHang_NV()
        {
            InitializeComponent();
            con = new SqlConnection(connectstring);
        }

        private void picTroVe_Click(object sender, EventArgs e)
        {

            frmBanHang trovenhe = new frmBanHang();
            trovenhe.Show();
            this.Close();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHTraiCayDataSet24.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter2.Fill(this.qLCHTraiCayDataSet24.KHACHHANG);
            // TODO: This line of code loads data into the 'qLCHTraiCayDataSet21.KHACHHANG' table. You can move, or remove it, as needed.
            
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
        private void ShowKhachHang(string query)
        {
            try
            {
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear(); // Xóa dữ liệu cũ
                adt.Fill(dt);
                dtgKhachHang.DataSource = dt;
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

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into KHACHHANG values(N'" + txtMaKHKH.Text + "',N'" + txtHoKHKH.Text + "',N'" + txtTenKHKH.Text + "','" + txtSdtKH.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công !");
                ShowKhachHang("select * from KHACHHANG");

                // Cập nhật lại DataGridView
                dtgKhachHang.Refresh();
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

        private void picSua_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE KHACHHANG SET HoKh = @HoKh, TenKh = @TenKh, Sdt = @Sdt WHERE MaKh = @MaKh";
                cmd.Parameters.AddWithValue("@HoKh", txtHoKHKH.Text);
                cmd.Parameters.AddWithValue("@TenKh", txtTenKHKH.Text);
                cmd.Parameters.AddWithValue("@Sdt", txtSdtKH.Text);
                cmd.Parameters.AddWithValue("@MaKh", txtMaKHKH.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
                ShowKhachHang("select * from KHACHHANG");

                // Cập nhật lại DataGridView
                dtgKhachHang.Refresh();
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
        private void picDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
            this.Close();
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "delete from KHACHHANG where MaKh = '" + txtMaKHKH.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    ShowKhachHang("select * from KHACHHANG");

                    // Cập nhật lại DataGridView
                    dtgKhachHang.Refresh();
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
       




        private void txtTimKiemKH_TextChanged(object sender, EventArgs e)
        {
            ShowKhachHang("SELECT * FROM KHACHHANG WHERE MaKh LIKE '%" + txtTkKhachHang.Text.Trim() + "%' OR HoKh LIKE N'%" + txtTkKhachHang.Text.Trim() + "%' OR TenKh LIKE N'%" + txtTkKhachHang.Text.Trim() + "%' OR Sdt LIKE '%" + txtTkKhachHang.Text.Trim() + "%' ");
        }

        private void frmKhachHang_Load1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHTraiCayDataSet21.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter1.Fill(this.qLCHTraiCayDataSet21.KHACHHANG);


        }

        private void dtgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgKhachHang.MultiSelect = true;
            int i;
            i = dtgKhachHang.CurrentRow.Index;
            txtMaKHKH.Text = dtgKhachHang.Rows[i].Cells[0].Value.ToString();
            txtHoKHKH.Text = dtgKhachHang.Rows[i].Cells[1].Value.ToString();
            txtTenKHKH.Text = dtgKhachHang.Rows[i].Cells[2].Value.ToString();
            txtSdtKH.Text = dtgKhachHang.Rows[i].Cells[3].Value.ToString();
        }
    }
}