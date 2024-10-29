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
    public partial class frmQuanLy : Form
    {
      
        public frmQuanLy()
        {
            InitializeComponent();
           
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanVien= new frmNhanVien();    
            nhanVien.Show();
            this.Hide();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham sanpham = new frmSanPham();
            sanpham.Show();
            this.Hide();
        }

       

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe thongke = new frmThongKe("Admin");
            thongke.Show();
            this.Hide();

        }

        private void btnKho_Click(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang khachHang = new frmKhachHang("Admin");
            khachHang.Show();
            this.Hide();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap ncc = new frmNhaCungCap();
            ncc.Show();
            this.Hide();
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.Show();
            this.Hide();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon hoadon = new frmHoaDon("Admin");
            hoadon.Show();
            this.Hide();
        }
    }
}
