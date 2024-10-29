namespace DoAnTraiCay
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgHoaDon = new System.Windows.Forms.DataGridView();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHTraiCayDataSet25 = new DoAnTraiCay.QLCHTraiCayDataSet25();
            this.lbXoa = new System.Windows.Forms.Label();
            this.lbSua = new System.Windows.Forms.Label();
            this.picXoa = new System.Windows.Forms.PictureBox();
            this.picSua = new System.Windows.Forms.PictureBox();
            this.picOut = new System.Windows.Forms.PictureBox();
            this.picTroVe = new System.Windows.Forms.PictureBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtNgayTao = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qlchTraiCayDataSet1 = new DoAnTraiCay.QLCHTraiCayDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgCTHD = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.hOADONTableAdapter = new DoAnTraiCay.QLCHTraiCayDataSet25TableAdapters.HOADONTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.mahdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachhangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTroVe)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlchTraiCayDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(611, 390);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dtgHoaDon
            // 
            this.dtgHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgHoaDon.AutoGenerateColumns = false;
            this.dtgHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.tenKhachhangDataGridViewTextBoxColumn});
            this.dtgHoaDon.DataSource = this.hOADONBindingSource;
            this.dtgHoaDon.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgHoaDon.Location = new System.Drawing.Point(6, 27);
            this.dtgHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgHoaDon.Name = "dtgHoaDon";
            this.dtgHoaDon.ReadOnly = true;
            this.dtgHoaDon.RowHeadersWidth = 62;
            this.dtgHoaDon.RowTemplate.Height = 28;
            this.dtgHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHoaDon.Size = new System.Drawing.Size(599, 359);
            this.dtgHoaDon.TabIndex = 27;
            this.dtgHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHoaDon_CellContentClick);
            this.dtgHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHoaDon_CellContentClick);
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qLCHTraiCayDataSet25;
            // 
            // qLCHTraiCayDataSet25
            // 
            this.qLCHTraiCayDataSet25.DataSetName = "QLCHTraiCayDataSet25";
            this.qLCHTraiCayDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbXoa
            // 
            this.lbXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbXoa.AutoSize = true;
            this.lbXoa.BackColor = System.Drawing.SystemColors.Info;
            this.lbXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXoa.Location = new System.Drawing.Point(570, 258);
            this.lbXoa.Name = "lbXoa";
            this.lbXoa.Size = new System.Drawing.Size(34, 16);
            this.lbXoa.TabIndex = 31;
            this.lbXoa.Text = "Xóa";
            // 
            // lbSua
            // 
            this.lbSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSua.AutoSize = true;
            this.lbSua.BackColor = System.Drawing.SystemColors.Info;
            this.lbSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSua.Location = new System.Drawing.Point(441, 258);
            this.lbSua.Name = "lbSua";
            this.lbSua.Size = new System.Drawing.Size(34, 16);
            this.lbSua.TabIndex = 32;
            this.lbSua.Text = "Sửa";
            // 
            // picXoa
            // 
            this.picXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picXoa.Image = ((System.Drawing.Image)(resources.GetObject("picXoa.Image")));
            this.picXoa.Location = new System.Drawing.Point(548, 207);
            this.picXoa.Name = "picXoa";
            this.picXoa.Size = new System.Drawing.Size(75, 67);
            this.picXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXoa.TabIndex = 28;
            this.picXoa.TabStop = false;
            this.picXoa.Click += new System.EventHandler(this.picXoa_Click);
            // 
            // picSua
            // 
            this.picSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSua.Image = ((System.Drawing.Image)(resources.GetObject("picSua.Image")));
            this.picSua.Location = new System.Drawing.Point(420, 207);
            this.picSua.Name = "picSua";
            this.picSua.Size = new System.Drawing.Size(75, 67);
            this.picSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSua.TabIndex = 29;
            this.picSua.TabStop = false;
            this.picSua.Click += new System.EventHandler(this.picSua_Click);
            // 
            // picOut
            // 
            this.picOut.Image = ((System.Drawing.Image)(resources.GetObject("picOut.Image")));
            this.picOut.Location = new System.Drawing.Point(202, 210);
            this.picOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOut.Name = "picOut";
            this.picOut.Size = new System.Drawing.Size(99, 64);
            this.picOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOut.TabIndex = 25;
            this.picOut.TabStop = false;
            this.picOut.Click += new System.EventHandler(this.picOut_Click);
            // 
            // picTroVe
            // 
            this.picTroVe.Image = ((System.Drawing.Image)(resources.GetObject("picTroVe.Image")));
            this.picTroVe.Location = new System.Drawing.Point(50, 210);
            this.picTroVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTroVe.Name = "picTroVe";
            this.picTroVe.Size = new System.Drawing.Size(99, 64);
            this.picTroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTroVe.TabIndex = 24;
            this.picTroVe.TabStop = false;
            this.picTroVe.Click += new System.EventHandler(this.picTroVe_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(122, 149);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(257, 22);
            this.txtTimKiem.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(39, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tìm Kiếm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtNgayTao);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(18, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1200, 76);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKH.Location = new System.Drawing.Point(671, 36);
            this.lblKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(121, 16);
            this.lblKH.TabIndex = 7;
            this.lblKH.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(335, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày tạo:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenKH.Location = new System.Drawing.Point(800, 33);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(189, 22);
            this.txtTenKH.TabIndex = 19;
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNgayTao.Location = new System.Drawing.Point(417, 29);
            this.txtNgayTao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(224, 22);
            this.txtNgayTao.TabIndex = 20;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaHoaDon.Location = new System.Drawing.Point(116, 30);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(189, 22);
            this.txtMaHoaDon.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // qlchTraiCayDataSet1
            // 
            this.qlchTraiCayDataSet1.DataSetName = "QLCHTraiCayDataSet";
            this.qlchTraiCayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dtgCTHD);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(629, 288);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(589, 390);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // dtgCTHD
            // 
            this.dtgCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCTHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCTHD.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgCTHD.Location = new System.Drawing.Point(6, 27);
            this.dtgCTHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCTHD.Name = "dtgCTHD";
            this.dtgCTHD.ReadOnly = true;
            this.dtgCTHD.RowHeadersWidth = 62;
            this.dtgCTHD.RowTemplate.Height = 28;
            this.dtgCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCTHD.Size = new System.Drawing.Size(577, 359);
            this.dtgCTHD.TabIndex = 27;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(400, 143);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 34);
            this.btnXem.TabIndex = 37;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(437, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quản Lý Hóa Đơn";
            // 
            // mahdDataGridViewTextBoxColumn
            // 
            this.mahdDataGridViewTextBoxColumn.DataPropertyName = "Mahd";
            this.mahdDataGridViewTextBoxColumn.HeaderText = "Mã Hóa Đơn";
            this.mahdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mahdDataGridViewTextBoxColumn.Name = "mahdDataGridViewTextBoxColumn";
            this.mahdDataGridViewTextBoxColumn.ReadOnly = true;
            this.mahdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "Ngày Tạo";
            this.ngayTaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            this.ngayTaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayTaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenKhachhangDataGridViewTextBoxColumn
            // 
            this.tenKhachhangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachhang";
            this.tenKhachhangDataGridViewTextBoxColumn.HeaderText = "Tên Khách Hàng";
            this.tenKhachhangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKhachhangDataGridViewTextBoxColumn.Name = "tenKhachhangDataGridViewTextBoxColumn";
            this.tenKhachhangDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenKhachhangDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1230, 689);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lbSua);
            this.Controls.Add(this.lbXoa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picXoa);
            this.Controls.Add(this.picSua);
            this.Controls.Add(this.picOut);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.picTroVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHoaDon";
            this.Text = "Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTroVe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlchTraiCayDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbXoa;
        private System.Windows.Forms.Label lbSua;
        private System.Windows.Forms.PictureBox picXoa;
        private System.Windows.Forms.PictureBox picSua;
        private System.Windows.Forms.DataGridView dtgHoaDon;
        private System.Windows.Forms.PictureBox picOut;
        private System.Windows.Forms.PictureBox picTroVe;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtNgayTao;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label1;
        private QLCHTraiCayDataSet qlchTraiCayDataSet1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgCTHD;
        private System.Windows.Forms.Button btnXem;
        private QLCHTraiCayDataSet25 qLCHTraiCayDataSet25;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QLCHTraiCayDataSet25TableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachhangDataGridViewTextBoxColumn;
    }
}