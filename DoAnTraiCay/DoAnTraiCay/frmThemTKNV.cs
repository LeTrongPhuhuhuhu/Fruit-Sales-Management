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
    public partial class frmThemTKNV : Form
    {   
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\DoAnTraiCay\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
     
        public frmThemTKNV()
        {
            InitializeComponent();
            con = new SqlConnection(connectstring);
  
        }



        private void ShowTaiKhoan()
        {
            try
            {
                dt.Clear();
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    cmd = new SqlCommand("select * from TAIKHOANNV ", con);
                    adt = new SqlDataAdapter(cmd);
                    dt.Clear(); // Xóa dữ liệu cũ
                    adt.Fill(dt);
                    dtgTaiKhoan.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnTroVeTKNV_Click(object sender, EventArgs e)
        {
            frmNhanVien trove = new frmNhanVien();
            trove.Show();
            this.Close();
        }

        private void btnDangXuatTKNV_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhapTKNV = new frmDangNhap();
            dangnhapTKNV.Show();
            this.Close();
        }

        private void frmThemTKNV_Load(object sender, EventArgs e)
        {
            Hienmanv();
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    // Lấy dữ liệu mới từ cơ sở dữ liệu
                    cmd = new SqlCommand("SELECT * FROM TAIKHOANNV", con);
                    adt = new SqlDataAdapter(cmd);
                    dt.Clear(); // Xóa dữ liệu cũ trong DataTable
                    adt.Fill(dt); // Lấy dữ liệu mới từ cơ sở dữ liệu
                    dtgTaiKhoan.DataSource = dt; // Cập nhật lại DataSource của DataGridView
                
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

        private void btnThemTKNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbMaTKNV.Text) && !string.IsNullOrEmpty(txtTKNV.Text) && !string.IsNullOrEmpty(txtMKNV.Text) && !string.IsNullOrEmpty(cb_Vaitro.Text)) { 
                    using (SqlConnection con = new SqlConnection(connectstring))
                    {
                        con.Open();

                        cmd = new SqlCommand("SELECT COUNT(*) FROM TAIKHOANNV WHERE TAIKHOAN = @TenTK", con);
                        cmd.Parameters.AddWithValue("@TenTK", txtTKNV.Text);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên tài khoản khác.");
                        }
                        else
                        {
                            cmd = con.CreateCommand();
                            cmd.CommandText = "insert into TAIKHOANNV values('" + cbMaTKNV.Text + "',N'" + txtTKNV.Text + "','" + txtMKNV.Text + "','" + cb_Vaitro.Text + "')";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công !");
                            ShowTaiKhoan();

                            // Cập nhật lại DataGridView
                            dtgTaiKhoan.Refresh();
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


      

        private void btnSuaTKNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbMaTKNV.Text) && !string.IsNullOrEmpty(txtTKNV.Text) && !string.IsNullOrEmpty(txtMKNV.Text) && !string.IsNullOrEmpty(cb_Vaitro.Text))

                {
                    using (SqlConnection con = new SqlConnection(connectstring))
                    {
                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandText = "UPDATE TAIKHOANNV SET TAIKHOAN = N'" + txtTKNV.Text + "', MATKHAU = N'" + txtMKNV.Text + "', VAITRO = N'" + cb_Vaitro.Text + "' WHERE MaNV = '" + cbMaTKNV.Text + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!");
                        ShowTaiKhoan();

                        // Cập nhật lại DataGridView
                        dtgTaiKhoan.Refresh();
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

        private void btnXoaTKNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbMaTKNV.Text) && !string.IsNullOrEmpty(txtTKNV.Text) && !string.IsNullOrEmpty(txtMKNV.Text) && !string.IsNullOrEmpty(cb_Vaitro.Text))

                {
                    using (SqlConnection con = new SqlConnection(connectstring))
                    {
                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandText = "delete from TAIKHOANNV where MaNV = '" + cbMaTKNV.Text + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        ShowTaiKhoan();

                        // Cập nhật lại DataGridView
                        dtgTaiKhoan.Refresh();
                        cleartxt() ;
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

        

        private void dtgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgTaiKhoan.MultiSelect = true;
            int i = dtgTaiKhoan.CurrentRow.Index;
            cbMaTKNV.Text = dtgTaiKhoan.Rows[i].Cells[0].Value.ToString();
            txtTKNV.Text = dtgTaiKhoan.Rows[i].Cells[1].Value.ToString();
            txtMKNV.Text = dtgTaiKhoan.Rows[i].Cells[2].Value.ToString();
            cb_Vaitro.SelectedValue = dtgTaiKhoan.Rows[i].Cells[3].Value.ToString();
        }
        public void Hienmanv()
        {
            string sSql;
            sSql = "SELECT MaNv FROM NHANVIEN";
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sSql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                cbMaTKNV.DataSource = ds.Tables[0];
                cbMaTKNV.DisplayMember = "MaNv";
                cbMaTKNV.ValueMember = "MaNv";
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI. Chi tiet: " + ex.Message);
            }
        }
        public void cleartxt()
        {
           
            txtTKNV.Clear();
            txtMKNV.Clear();
            
         }
    }
}
