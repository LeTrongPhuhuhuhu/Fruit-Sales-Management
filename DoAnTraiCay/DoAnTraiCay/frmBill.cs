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
using Microsoft.Reporting.WinForms;

namespace DoAnTraiCay
{
    public partial class frmBill : Form
    {
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\DoAnTraiCay\\DeAnTraiCay\\DoAnTraiCay\\DoAnTraiCay\\QLCHTraiCay.mdf;Integrated Security=True";
        SqlConnection con;

        public frmBill()
        {
            InitializeComponent();
            con = new SqlConnection(connectstring);
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            string sSql = "SELECT*FROM CT_SANPHAM";
            SqlDataAdapter da = new SqlDataAdapter(sSql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "CT_SANPHAM");
            this.rpBill.LocalReport.ReportEmbeddedResource = "DoAnTraiCay.inbill.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["CT_SANPHAM"];
            this.rpBill.LocalReport.DataSources.Add(rds);
            this.rpBill.RefreshReport();
        }
    }

}
