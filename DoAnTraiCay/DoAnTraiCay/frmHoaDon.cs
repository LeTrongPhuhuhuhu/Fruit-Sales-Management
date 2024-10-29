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
namespace DoAnTraiCay
{
    public partial class frmHoaDon : Form
    {
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\DoAnTraiCay\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        string VAITRO;
        public frmHoaDon(string vaitro)
        {
            InitializeComponent();
            VAITRO = vaitro;

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            KIEMTRA();

            try
            {
                con = new SqlConnection(connectstring);

                {
                    con.Open();
                    string query = "SELECT * FROM HOADON";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dtgHoaDon.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi. Chi tiết: " + ex.Message);
            }


        }



        private void picTroVe_Click(object sender, EventArgs e)
        {
            if (VAITRO != "Admin")
            {
                frmHomePage nhanvien = new frmHomePage();
                nhanvien.Show();
                this.Hide();
            }
            else
            {
                frmQuanLy quanly = new frmQuanLy();
                quanly.Show();
                this.Hide();
            }
        }

        private void picOut_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap= new frmDangNhap();
            dangnhap.Show();
            this.Hide();
        }

        private void dtgHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dtgHoaDon.MultiSelect = true;
            int i;
            i = dtgHoaDon.CurrentRow.Index;
            txtMaHoaDon.Text = dtgHoaDon.Rows[i].Cells[0].Value.ToString();
            txtNgayTao.Text = dtgHoaDon.Rows[i].Cells[1].Value.ToString();
            txtTenKH.Text = dtgHoaDon.Rows[i].Cells[2].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void KIEMTRA()
        {
            if (VAITRO != "Admin")
            {
                picXoa.Visible = false;
                picSua.Visible = false;
                lbSua.Visible = false;
                lbXoa.Visible = false;
            }
        }

        private void ShowHoaDon(string query)
        {
            try
            {
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt.Clear(); // Xóa dữ liệu cũ
                adt.Fill(dt);
                dtgHoaDon.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void picXoa_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    
                    cmd.CommandText = "delete from CT_HOADON where MaHd = '" + txtMaHoaDon.Text + "'";
                    
                    cmd.ExecuteNonQuery();
                    SqlCommand cmdDeleteInvoice = con.CreateCommand();
                    cmdDeleteInvoice.CommandText = "DELETE FROM HOADON WHERE MaHd = @MaHd";
                    cmdDeleteInvoice.Parameters.AddWithValue("@MaHd", txtMaHoaDon.Text);
                    cmdDeleteInvoice.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công!","Thông báo",MessageBoxButtons.OK);
                    ShowHoaDon("SELECT * FROM HOADON");

                    

                    // Cập nhật lại DataGridView
                    dtgHoaDon.Refresh();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        private void picSua_Click(object sender, EventArgs e)
        {


            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE HOADON SET MaHd = '" + txtMaHoaDon.Text + "', MaSp = '" + txtNgayTao.Text + "', TenSp = N'" + txtTenKH.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa hóa đơn thành công!");
                    ShowHoaDon("select * from HOADON");

                    // Cập nhật lại DataGridView
                    dtgHoaDon.Refresh();
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mã hóa đơn đã được nhập chưa
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                // Kiểm tra xem kết nối đã được mở chưa
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM CT_HOADON WHERE MaHd='" + txtTimKiem.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgCTHD.DataSource = dataTable;
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            else
            {
                // Hiển thị thông báo nếu chưa nhập mã hóa đơn
                MessageBox.Show("Vui lòng nhập mã hóa đơn!");
            }
        }


    }
}