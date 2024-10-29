using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTraiCay
{
    public partial class frmKhachHang : Form
    {
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\DoAnTraiCay\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        string VAITRO;
        public frmKhachHang(string vaitro)
        {
            InitializeComponent();
            con = new SqlConnection(connectstring);
            VAITRO = vaitro;
        }

       public void cleartxt()
        {
            txtMaKHKH.Clear();
            txtHoKHKH.Clear();
            txtTenKHKH.Clear();
            txtSdtKH.Clear();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            TangMaKH();
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
        public void TangMaKH()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT MAX(MaKh) FROM KHACHHANG";
                    object kq = cmd.ExecuteScalar();
                    int MaNv = 0;
                    if (kq != null)
                    {
                        MaNv = int.Parse(kq.ToString());
                    }
                    MaNv++;
                    txtMaKHKH.Text = MaNv.ToString();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (!string.IsNullOrEmpty(txtMaKHKH.Text) && !string.IsNullOrEmpty(txtHoKHKH.Text) && !string.IsNullOrEmpty(txtTenKHKH.Text) && !string.IsNullOrEmpty(txtSdtKH.Text))
                {
                    
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT count(MaKh)  FROM KHACHHANG WHERE MaKh = @MaKh";
                    cmd.Parameters.AddWithValue("@MaKh", txtMaKHKH.Text);
                    
                    int soluongkh = (int)cmd.ExecuteScalar();
                    if (soluongkh > 0)
                    {
                        MessageBox.Show("Đã có mã khách hàng này rồi ! \n Vui lòng nhập mã khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                    cmd.CommandText = "SELECT count(Sdt)  FROM KHACHHANG WHERE Sdt = @Sdt";
                    cmd.Parameters.AddWithValue("@Sdt", txtSdtKH.Text);
                    int soluongsdt = (int)cmd.ExecuteScalar();
                    if (soluongsdt > 0)
                    {
                        MessageBox.Show("Đã có số điện thoại này rồi ! \n Vui lòng nhập số khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   if(KTSDT())
                   {
                        
                                cmd.CommandText = "insert into KHACHHANG values(N'" + txtMaKHKH.Text + "',N'" + txtHoKHKH.Text + "',N'" + txtTenKHKH.Text + "','" + txtSdtKH.Text + "')";
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Thêm thành công !");
                                ShowKhachHang("select * from KHACHHANG");

                                // Cập nhật lại DataGridView
                                dtgKhachHang.Refresh();
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
                KTSDT();
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
                if (!string.IsNullOrEmpty(txtMaKHKH.Text) && !string.IsNullOrEmpty(txtHoKHKH.Text) && !string.IsNullOrEmpty(txtTenKHKH.Text) && !string.IsNullOrEmpty(txtSdtKH.Text))
                {
                    if(KTSDT())
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
        private void picTroVe_Click(object sender, EventArgs e)
        {
            if (VAITRO != "Admin")
            {
                frmBanHang nhanvien = new frmBanHang();
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

        private void picXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaKHKH.Text) && !string.IsNullOrEmpty(txtHoKHKH.Text) && !string.IsNullOrEmpty(txtTenKHKH.Text) && !string.IsNullOrEmpty(txtSdtKH.Text))
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

        private void txtTkKhachHang_TextChanged(object sender, EventArgs e)
        {
            ShowKhachHang("SELECT * FROM KHACHHANG WHERE HoKh LIKE N'%" + txtHoKHKH.Text.Trim() + "%' OR TenKh LIKE N'%" + txtTenKHKH.Text.Trim() + "%'");
        }
        public bool KTSDT()
        {
            string sdt = txtSdtKH.Text;
            Regex rg = new Regex(@"^\d{10}$");
            Match match = rg.Match(sdt);
            if (!match.Success)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}