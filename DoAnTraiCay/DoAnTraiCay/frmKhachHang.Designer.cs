namespace DoAnTraiCay
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.dtgKhachHang = new System.Windows.Forms.DataGridView();
            this.maKhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoKhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHTraiCayDataSet24 = new DoAnTraiCay.QLCHTraiCayDataSet24();
            this.kHACHHANGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHTraiCayDataSet21 = new DoAnTraiCay.QLCHTraiCayDataSet21();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHTraiCayDataSet20 = new DoAnTraiCay.QLCHTraiCayDataSet20();
            this.kHACHHANGTableAdapter = new DoAnTraiCay.QLCHTraiCayDataSet20TableAdapters.KHACHHANGTableAdapter();
            this.kHACHHANGTableAdapter1 = new DoAnTraiCay.QLCHTraiCayDataSet21TableAdapters.KHACHHANGTableAdapter();
            this.kHACHHANGTableAdapter2 = new DoAnTraiCay.QLCHTraiCayDataSet24TableAdapters.KHACHHANGTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picDangXuat = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSdtKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKHKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoKHKH = new System.Windows.Forms.TextBox();
            this.txtMaKHKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTkKhachHang = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.picSua = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.picXoa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgKhachHang
            // 
            this.dtgKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgKhachHang.AutoGenerateColumns = false;
            this.dtgKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhDataGridViewTextBoxColumn,
            this.hoKhDataGridViewTextBoxColumn,
            this.tenKhDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn});
            this.dtgKhachHang.DataSource = this.kHACHHANGBindingSource2;
            this.dtgKhachHang.Location = new System.Drawing.Point(333, 118);
            this.dtgKhachHang.Name = "dtgKhachHang";
            this.dtgKhachHang.ReadOnly = true;
            this.dtgKhachHang.RowHeadersWidth = 62;
            this.dtgKhachHang.RowTemplate.Height = 28;
            this.dtgKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgKhachHang.Size = new System.Drawing.Size(931, 506);
            this.dtgKhachHang.TabIndex = 6;
            this.dtgKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKhachHang_CellClick);
            // 
            // maKhDataGridViewTextBoxColumn
            // 
            this.maKhDataGridViewTextBoxColumn.DataPropertyName = "MaKh";
            this.maKhDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.maKhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maKhDataGridViewTextBoxColumn.Name = "maKhDataGridViewTextBoxColumn";
            this.maKhDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKhDataGridViewTextBoxColumn.Width = 200;
            // 
            // hoKhDataGridViewTextBoxColumn
            // 
            this.hoKhDataGridViewTextBoxColumn.DataPropertyName = "HoKh";
            this.hoKhDataGridViewTextBoxColumn.HeaderText = "Họ KH";
            this.hoKhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoKhDataGridViewTextBoxColumn.Name = "hoKhDataGridViewTextBoxColumn";
            this.hoKhDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoKhDataGridViewTextBoxColumn.Width = 250;
            // 
            // tenKhDataGridViewTextBoxColumn
            // 
            this.tenKhDataGridViewTextBoxColumn.DataPropertyName = "TenKh";
            this.tenKhDataGridViewTextBoxColumn.HeaderText = "Tên KH";
            this.tenKhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenKhDataGridViewTextBoxColumn.Name = "tenKhDataGridViewTextBoxColumn";
            this.tenKhDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenKhDataGridViewTextBoxColumn.Width = 250;
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "Sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sdtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            this.sdtDataGridViewTextBoxColumn.ReadOnly = true;
            this.sdtDataGridViewTextBoxColumn.Width = 250;
            // 
            // kHACHHANGBindingSource2
            // 
            this.kHACHHANGBindingSource2.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource2.DataSource = this.qLCHTraiCayDataSet24;
            // 
            // qLCHTraiCayDataSet24
            // 
            this.qLCHTraiCayDataSet24.DataSetName = "QLCHTraiCayDataSet24";
            this.qLCHTraiCayDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource1
            // 
            this.kHACHHANGBindingSource1.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource1.DataSource = this.qLCHTraiCayDataSet21;
            // 
            // qLCHTraiCayDataSet21
            // 
            this.qLCHTraiCayDataSet21.DataSetName = "QLCHTraiCayDataSet21";
            this.qLCHTraiCayDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qLCHTraiCayDataSet20;
            // 
            // qLCHTraiCayDataSet20
            // 
            this.qLCHTraiCayDataSet20.DataSetName = "QLCHTraiCayDataSet20";
            this.qLCHTraiCayDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // kHACHHANGTableAdapter1
            // 
            this.kHACHHANGTableAdapter1.ClearBeforeFill = true;
            // 
            // kHACHHANGTableAdapter2
            // 
            this.kHACHHANGTableAdapter2.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.picTroVe_Click);
            // 
            // picDangXuat
            // 
            this.picDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("picDangXuat.Image")));
            this.picDangXuat.Location = new System.Drawing.Point(1158, 4);
            this.picDangXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picDangXuat.Name = "picDangXuat";
            this.picDangXuat.Size = new System.Drawing.Size(82, 66);
            this.picDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDangXuat.TabIndex = 16;
            this.picDangXuat.TabStop = false;
            this.picDangXuat.Click += new System.EventHandler(this.picOut_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.picDangXuat);
            this.panel2.Location = new System.Drawing.Point(4, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 83);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSdtKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenKHKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoKHKH);
            this.groupBox1.Controls.Add(this.txtMaKHKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(4, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 676);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên KH:";
            // 
            // txtSdtKH
            // 
            this.txtSdtKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSdtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdtKH.Location = new System.Drawing.Point(94, 405);
            this.txtSdtKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdtKH.MaxLength = 10;
            this.txtSdtKH.Name = "txtSdtKH";
            this.txtSdtKH.Size = new System.Drawing.Size(212, 24);
            this.txtSdtKH.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ KH:";
            // 
            // txtTenKHKH
            // 
            this.txtTenKHKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenKHKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKHKH.Location = new System.Drawing.Point(101, 277);
            this.txtTenKHKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKHKH.Name = "txtTenKHKH";
            this.txtTenKHKH.Size = new System.Drawing.Size(212, 24);
            this.txtTenKHKH.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "SĐT:";
            // 
            // txtHoKHKH
            // 
            this.txtHoKHKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHoKHKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoKHKH.Location = new System.Drawing.Point(101, 158);
            this.txtHoKHKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoKHKH.Name = "txtHoKHKH";
            this.txtHoKHKH.Size = new System.Drawing.Size(205, 24);
            this.txtHoKHKH.TabIndex = 9;
            // 
            // txtMaKHKH
            // 
            this.txtMaKHKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaKHKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKHKH.Location = new System.Drawing.Point(101, 69);
            this.txtMaKHKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKHKH.Name = "txtMaKHKH";
            this.txtMaKHKH.Size = new System.Drawing.Size(212, 24);
            this.txtMaKHKH.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã KH:";
            // 
            // txtTkKhachHang
            // 
            this.txtTkKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTkKhachHang.Location = new System.Drawing.Point(419, 88);
            this.txtTkKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTkKhachHang.Name = "txtTkKhachHang";
            this.txtTkKhachHang.Size = new System.Drawing.Size(370, 22);
            this.txtTkKhachHang.TabIndex = 12;
            this.txtTkKhachHang.TextChanged += new System.EventHandler(this.txtTkKhachHang_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(795, 82);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(168, 38);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.txtTimKiemKH_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.picAdd);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.picSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.picXoa);
            this.panel1.Location = new System.Drawing.Point(333, 629);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 134);
            this.panel1.TabIndex = 13;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(723, 84);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 48);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.picXoa_Click);
            // 
            // picAdd
            // 
            this.picAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAdd.Enabled = false;
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(42, 15);
            this.picAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(110, 73);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 16;
            this.picAdd.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(381, 89);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 43);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.picSua_Click);
            // 
            // picSua
            // 
            this.picSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picSua.Enabled = false;
            this.picSua.Image = ((System.Drawing.Image)(resources.GetObject("picSua.Image")));
            this.picSua.Location = new System.Drawing.Point(381, 15);
            this.picSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSua.Name = "picSua";
            this.picSua.Size = new System.Drawing.Size(110, 73);
            this.picSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSua.TabIndex = 19;
            this.picSua.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(42, 88);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // picXoa
            // 
            this.picXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picXoa.Enabled = false;
            this.picXoa.Image = ((System.Drawing.Image)(resources.GetObject("picXoa.Image")));
            this.picXoa.Location = new System.Drawing.Point(723, 15);
            this.picXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picXoa.Name = "picXoa";
            this.picXoa.Size = new System.Drawing.Size(121, 68);
            this.picXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXoa.TabIndex = 17;
            this.picXoa.TabStop = false;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1254, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTkKhachHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgKhachHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgKhachHang;
        private QLCHTraiCayDataSet20 qLCHTraiCayDataSet20;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLCHTraiCayDataSet20TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private QLCHTraiCayDataSet21 qLCHTraiCayDataSet21;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource1;
        private QLCHTraiCayDataSet21TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter1;
        private QLCHTraiCayDataSet24 qLCHTraiCayDataSet24;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource2;
        private QLCHTraiCayDataSet24TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picDangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSdtKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKHKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoKHKH;
        private System.Windows.Forms.TextBox txtMaKHKH;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTkKhachHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.PictureBox picSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.PictureBox picXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoKhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
    }
}