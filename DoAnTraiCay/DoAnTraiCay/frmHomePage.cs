using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTraiCay
{
    public partial class frmHomePage : Form
    {
        

        public frmHomePage()
        {
            InitializeComponent();
            
        }

        private void FrmQuanLy_Load(object sender, EventArgs e)
        {

        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {

            int gio, phut, giay;
            gio = DateTime.Now.Hour;
            phut = DateTime.Now.Minute;
            giay = DateTime.Now.Second;
            lblGioHienTai.Text = gio.ToString() + ":" + phut.ToString() + ":" + giay.ToString();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dangxuatnhe= new frmDangNhap();
            dangxuatnhe.Show();
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe thongke = new frmThongKe("NhanVien");
            thongke.Show();
            this.Hide();
        }

        private void btn_Banhang_Click(object sender, EventArgs e)
        {
            frmBanHang hang = new frmBanHang();
            hang.Show();
            this.Close();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon hoaDon_NV = new frmHoaDon("NhanVien");
            hoaDon_NV.Show();
            this.Close();
        }
    }
}
