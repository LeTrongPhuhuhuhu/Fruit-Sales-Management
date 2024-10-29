using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnTraiCay
{
    public partial class frmThongKe : Form
    {
        string scon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\DoAnTraiCay\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        string VAITRO;

        public frmThongKe(string vAITRO)
        {
            InitializeComponent();
            con = new SqlConnection(scon);
            VAITRO = vAITRO;
        }

        private void frmdemothongke_Load(object sender, EventArgs e)
        {
            cbbNgayThangNam.Enabled = false;
            dtpBatDau.Enabled = false;
            dtpKetThuc.Enabled = false;
            radChonNgay.Checked = false;
            radNgayThangnam.Checked = false;
        }

        private void radNgayThangnam_CheckedChanged(object sender, EventArgs e)
        {
            if (radNgayThangnam.Checked == true)
            {
                cbbNgayThangNam.Enabled = true;
                dtpBatDau.Enabled = false;
                dtpKetThuc.Enabled = false;
            }
        }

        private void radChonNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radChonNgay.Checked == true)
            {
                cbbNgayThangNam.Enabled = false;
                dtpBatDau.Enabled = true;
                dtpKetThuc.Enabled = true;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (radNgayThangnam.Checked == true)
            {
                if (cbbNgayThangNam.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn ngày,tháng hoặc năm!", "Thông báo");
                }
                else
                {
                    string chon = cbbNgayThangNam.SelectedItem.ToString();

                    switch (chon)
                    {
                        case "Ngày":
                            string queryngay = "SELECT SUM(ct.ThanhTien) AS TongDoanhThu, " +
                                "COUNT (DISTINCT hd.Mahd) AS TongSoDonHang," +
                                "SUM(ct.SoLuong) AS TongSoLuong " +
                                "FROM CT_HOADON ct " +
                                "INNER JOIN SANPHAM sp ON ct.MaSp = sp.MaSP " +
                                "INNER JOIN HOADON hd ON hd.Mahd = ct.MaHd " +
                                "WHERE CAST(hd.NgayTao AS DATE) = CAST(GETDATE() AS DATE)";
                            string top3ngay = "SELECT TOP 3 sp.TenSP, SUM(ct.SoLuong) AS TongSoLuong " +
                                                "FROM CT_HOADON ct " +
                                                "INNER JOIN SANPHAM sp ON ct.MaSp = sp.MaSP " +
                                                "INNER JOIN HOADON hd ON hd.Mahd = ct.MaHd " +
                                                "WHERE CAST(hd.NgayTao AS DATE) = CAST(GETDATE() AS DATE) " +
                                                "GROUP BY sp.TenSP " +
                                                "ORDER BY TongSoLuong DESC";
                            Top3(top3ngay);
                            HienLenTextbox(queryngay);
                            break;
                        case "Tháng":
                            string querythang = "SELECT SUM(ct.ThanhTien) AS TongDoanhThu, " +
                                "COUNT (DISTINCT hd.Mahd) AS TongSoDonHang," +
                                 "SUM(ct.SoLuong) AS TongSoLuong " +
                                "FROM CT_HOADON ct " +
                                "INNER JOIN SANPHAM sp ON ct.MaSp = sp.MaSP " +
                                "INNER JOIN HOADON hd ON hd.Mahd = ct.MaHd " +
                                "WHERE MONTH(hd.NgayTao) = MONTH(GETDATE())";
                            string top3thang = "SELECT TOP 3 sp.TenSP, SUM(ct.SoLuong) AS TongSoLuong " +
                                                "FROM CT_HOADON ct " +
                                                "INNER JOIN SANPHAM sp ON ct.MaSp = sp.MaSP " +
                                                "INNER JOIN HOADON hd ON hd.Mahd = ct.MaHd " +
                                                "WHERE MONTH(hd.NgayTao) = MONTH(GETDATE()) " +
                                                "GROUP BY sp.TenSP " +
                                                "ORDER BY TongSoLuong DESC";
                            Top3(top3thang);
                            HienLenTextbox(querythang);
                            break;
                        case "Năm":
                            string querynam = "SELECT SUM(ct.ThanhTien) AS TongDoanhThu, " +
                                "COUNT (DISTINCT hd.Mahd) AS TongSoDonHang," +
                                 "SUM(ct.SoLuong) AS TongSoLuong " +
                                "FROM CT_HOADON ct " +
                                "INNER JOIN SANPHAM sp ON ct.MaSp = sp.MaSP " +
                                "INNER JOIN HOADON hd ON hd.Mahd = ct.MaHd " +
                                "WHERE YEAR(hd.NgayTao) = YEAR(GETDATE())";
                            string top3nam = "SELECT TOP 3 sp.TenSP, SUM(ct.SoLuong) AS TongSoLuong " +
                                            "FROM CT_HOADON ct " +
                                            "INNER JOIN SANPHAM sp ON ct.MaSp = sp.MaSP " +
                                            "INNER JOIN HOADON hd ON hd.Mahd = ct.MaHd " +
                                            "WHERE YEAR(hd.NgayTao) = YEAR(GETDATE()) " +
                                            "GROUP BY sp.TenSP " +
                                            "ORDER BY TongSoLuong DESC";
                            Top3(top3nam);
                            HienLenTextbox(querynam);
                            break;
                    }


                }
            }
            else if (radChonNgay.Checked == true)
            {
                DateTime NgayBatDau = dtpBatDau.Value;
                DateTime NgayKetThuc = dtpKetThuc.Value;
                string querychonngay = "SELECT SUM(ct.ThanhTien) AS TongDoanhThu, " +
                            "COUNT (DISTINCT hd.Mahd) AS TongSoDonHang," +
                             "SUM(ct.SoLuong) AS TongSoLuong " +
                            "FROM CT_HOADON ct " +
                            "INNER JOIN HOADON hd ON hd.Mahd = ct.MaHd " +
                            $"WHERE hd.NgayTao BETWEEN '{NgayBatDau.ToString("yyyy-MM-dd")}' AND '{NgayKetThuc.ToString("yyyy-MM-dd")}'";
                string queryTop3ChonNgay = "SELECT TOP 3 sp.TenSP, SUM(ct.SoLuong) AS TongSoLuong " +
                                            "FROM CT_HOADON ct " +
                                            "INNER JOIN SANPHAM sp ON ct.MaSp = sp.MaSP " +
                                            "INNER JOIN HOADON hd ON hd.Mahd = ct.MaHd " +
                                            $"WHERE hd.NgayTao BETWEEN '{NgayBatDau.ToString("yyyy-MM-dd")}' AND '{NgayKetThuc.ToString("yyyy-MM-dd")}' " +
                                            "GROUP BY sp.TenSP " +
                                            "ORDER BY TongSoLuong DESC";
                Top3(queryTop3ChonNgay);
                HienLenTextbox(querychonngay);
            }


        }
        public void Top3(string querytop3)
        {

            HienLenChart2(querytop3);
        }

        public void HienLenTextbox(string query)
        {
            DataTable dt = ExecuteSQLQuery(query);

            // Cập nhật các label với kết quả truy vấn
            lblTongTien.Text = dt.Rows[0]["TongDoanhThu"].ToString();
            lblTongHoaDon.Text = dt.Rows[0]["TongSoDonHang"].ToString();
            lblTongSoLuong.Text = dt.Rows[0]["TongSoLuong"].ToString();

            // Thêm dữ liệu vào biểu đồ
            chartDoanhThu.Series["colTongDoanhThu"].Points.Clear();
            chartDoanhThu.Series["colTongDoanhThu"].Points.AddXY("Tổng doanh thu", dt.Rows[0]["TongDoanhThu"]);
            chartHoaDon.Series["colHoaDon"].Points.Clear();
            chartHoaDon.Series["colSoLuong"].Points.Clear();
            chartHoaDon.Series["colHoaDon"].Points.AddXY("Tổng số đơn hàng", dt.Rows[0]["TongSoDonHang"]);
            chartHoaDon.Series["colSoLuong"].Points.AddXY("Tổng số sản phẩm", dt.Rows[0]["TongSoLuong"]);

        }

        public void HienLenChart2(string query)
        {

            DataTable dt = ExecuteSQLQuery(query);

            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].ChartType = SeriesChartType.Pie;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart2.Series["Series1"].Points.AddXY(dt.Rows[i]["TenSP"], dt.Rows[i]["TongSoLuong"]);
            }
        }

        private DataTable ExecuteSQLQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(scon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (VAITRO == "Admin")
            {
                frmQuanLy quanLy = new frmQuanLy();
                quanLy.Show();
                this.Hide();
            }
            else if (VAITRO == "NhanVien")
            {
                frmHomePage homePage = new frmHomePage();
                homePage.Show();
                this.Hide();
            }
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.Show();
            this.Hide();
        }
    }
}
