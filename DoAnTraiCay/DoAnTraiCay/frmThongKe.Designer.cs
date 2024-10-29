namespace DoAnTraiCay
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.chartHoaDon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.lblTongSoLuong = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picDangXuat = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.radChonNgay = new System.Windows.Forms.RadioButton();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbNgayThangNam = new System.Windows.Forms.ComboBox();
            this.radNgayThangnam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartHoaDon
            // 
            this.chartHoaDon.CausesValidation = false;
            chartArea7.Name = "ChartArea1";
            this.chartHoaDon.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartHoaDon.Legends.Add(legend7);
            this.chartHoaDon.Location = new System.Drawing.Point(7, 398);
            this.chartHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartHoaDon.Name = "chartHoaDon";
            this.chartHoaDon.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.LegendText = "Hóa Đơn";
            series9.Name = "colHoaDon";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.LegendText = "Số Lượng Sản Phẩm";
            series10.Name = "colSoLuong";
            this.chartHoaDon.Series.Add(series9);
            this.chartHoaDon.Series.Add(series10);
            this.chartHoaDon.Size = new System.Drawing.Size(687, 288);
            this.chartHoaDon.TabIndex = 41;
            this.chartHoaDon.Text = "chart3";
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.AutoSize = true;
            this.lblTongHoaDon.Location = new System.Drawing.Point(147, 81);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(0, 26);
            this.lblTongHoaDon.TabIndex = 0;
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.AutoSize = true;
            this.lblTongSoLuong.Location = new System.Drawing.Point(145, 81);
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(0, 26);
            this.lblTongSoLuong.TabIndex = 0;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(700, 104);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart2.Name = "chart2";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(501, 584);
            this.chart2.TabIndex = 40;
            this.chart2.Text = "chart2";
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.CausesValidation = false;
            chartArea9.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend9);
            this.chartDoanhThu.Location = new System.Drawing.Point(7, 104);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.LegendText = "Doanh Thu";
            series12.Name = "colTongDoanhThu";
            this.chartDoanhThu.Series.Add(series12);
            this.chartDoanhThu.Size = new System.Drawing.Size(687, 288);
            this.chartDoanhThu.TabIndex = 39;
            this.chartDoanhThu.Text = "chart1";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(159, 81);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 26);
            this.lblTongTien.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.picDangXuat);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-13, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 84);
            this.panel2.TabIndex = 42;
            // 
            // picDangXuat
            // 
            this.picDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("picDangXuat.Image")));
            this.picDangXuat.Location = new System.Drawing.Point(1161, 0);
            this.picDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picDangXuat.Name = "picDangXuat";
            this.picDangXuat.Size = new System.Drawing.Size(82, 80);
            this.picDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDangXuat.TabIndex = 16;
            this.picDangXuat.TabStop = false;
            this.picDangXuat.Click += new System.EventHandler(this.picDangXuat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXem.Location = new System.Drawing.Point(949, 886);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(147, 46);
            this.btnXem.TabIndex = 38;
            this.btnXem.Text = "Xem ";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // radChonNgay
            // 
            this.radChonNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radChonNgay.AutoSize = true;
            this.radChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChonNgay.Location = new System.Drawing.Point(294, 841);
            this.radChonNgay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radChonNgay.Name = "radChonNgay";
            this.radChonNgay.Size = new System.Drawing.Size(187, 29);
            this.radChonNgay.TabIndex = 36;
            this.radChonNgay.TabStop = true;
            this.radChonNgay.Text = "Chọn Thời Gian";
            this.radChonNgay.UseVisualStyleBackColor = true;
            this.radChonNgay.Click += new System.EventHandler(this.radChonNgay_CheckedChanged);
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpKetThuc.CustomFormat = "yyyy-MM-dd";
            this.dtpKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKetThuc.Location = new System.Drawing.Point(651, 890);
            this.dtpKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(237, 31);
            this.dtpKetThuc.TabIndex = 35;
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpBatDau.CustomFormat = "yyyy-MM-dd";
            this.dtpBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatDau.Location = new System.Drawing.Point(331, 890);
            this.dtpBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(237, 31);
            this.dtpBatDau.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 892);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 892);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Từ :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Navy;
            this.groupBox3.Controls.Add(this.lblTongHoaDon);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(577, 700);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(278, 122);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Indigo;
            this.groupBox2.Controls.Add(this.lblTongSoLuong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(293, 700);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(278, 122);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng Số Lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(7, 700);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(278, 122);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng Tiền";
            // 
            // cbbNgayThangNam
            // 
            this.cbbNgayThangNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbNgayThangNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNgayThangNam.FormattingEnabled = true;
            this.cbbNgayThangNam.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.cbbNgayThangNam.Location = new System.Drawing.Point(52, 887);
            this.cbbNgayThangNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbNgayThangNam.Name = "cbbNgayThangNam";
            this.cbbNgayThangNam.Size = new System.Drawing.Size(159, 33);
            this.cbbNgayThangNam.TabIndex = 31;
            // 
            // radNgayThangnam
            // 
            this.radNgayThangnam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radNgayThangnam.AutoSize = true;
            this.radNgayThangnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgayThangnam.Location = new System.Drawing.Point(52, 841);
            this.radNgayThangnam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radNgayThangnam.Name = "radNgayThangnam";
            this.radNgayThangnam.Size = new System.Drawing.Size(207, 29);
            this.radNgayThangnam.TabIndex = 37;
            this.radNgayThangnam.TabStop = true;
            this.radNgayThangnam.Text = "Thời điểm hiện tại";
            this.radNgayThangnam.UseVisualStyleBackColor = true;
            this.radNgayThangnam.Click += new System.EventHandler(this.radNgayThangnam_CheckedChanged);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 948);
            this.Controls.Add(this.chartHoaDon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chartDoanhThu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.radChonNgay);
            this.Controls.Add(this.radNgayThangnam);
            this.Controls.Add(this.dtpKetThuc);
            this.Controls.Add(this.dtpBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbNgayThangNam);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.frmdemothongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHoaDon;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.Label lblTongSoLuong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picDangXuat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.RadioButton radChonNgay;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbNgayThangNam;
        private System.Windows.Forms.RadioButton radNgayThangnam;
    }
}