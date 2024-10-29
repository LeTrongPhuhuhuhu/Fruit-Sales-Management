namespace DoAnTraiCay
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dtgSanpham = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sANPHAMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHTraiCayDataSet1 = new DoAnTraiCay.QLCHTraiCayDataSet1();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHTraiCayDataSet = new DoAnTraiCay.QLCHTraiCayDataSet();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTitle2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picTroVe = new System.Windows.Forms.PictureBox();
            this.picDangXuat = new System.Windows.Forms.PictureBox();
            this.sANPHAMTableAdapter = new DoAnTraiCay.QLCHTraiCayDataSetTableAdapters.SANPHAMTableAdapter();
            this.sANPHAMTableAdapter1 = new DoAnTraiCay.QLCHTraiCayDataSet1TableAdapters.SANPHAMTableAdapter();
            this.picXoa = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.picSua = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_ThongTinSP = new System.Windows.Forms.GroupBox();
            this.nb_soluong = new System.Windows.Forms.NumericUpDown();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.dpOutDate = new System.Windows.Forms.DateTimePicker();
            this.dpNhap = new System.Windows.Forms.DateTimePicker();
            this.cbb_TenNCC = new System.Windows.Forms.ComboBox();
            this.cbDonVi = new System.Windows.Forms.ComboBox();
            this.lblMaNcc = new System.Windows.Forms.Label();
            this.lblMaSp = new System.Windows.Forms.Label();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenSp = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTroVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.panel1.SuspendLayout();
            this.grp_ThongTinSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(705, 79);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(149, 30);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(412, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 16);
            this.lbTitle.TabIndex = 0;
            // 
            // dtgSanpham
            // 
            this.dtgSanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSanpham.AutoGenerateColumns = false;
            this.dtgSanpham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn,
            this.soLuongSPDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.maNCCDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn,
            this.ngayHetHanDataGridViewTextBoxColumn});
            this.dtgSanpham.DataSource = this.sANPHAMBindingSource1;
            this.dtgSanpham.Location = new System.Drawing.Point(317, 113);
            this.dtgSanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgSanpham.Name = "dtgSanpham";
            this.dtgSanpham.ReadOnly = true;
            this.dtgSanpham.RowHeadersWidth = 62;
            this.dtgSanpham.RowTemplate.Height = 28;
            this.dtgSanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSanpham.Size = new System.Drawing.Size(785, 386);
            this.dtgSanpham.TabIndex = 5;
            this.dtgSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSanpham_CellClick);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.maSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên SP";
            this.tenSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "DonVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "Đơn Vị";
            this.donViDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            this.donViDataGridViewTextBoxColumn.ReadOnly = true;
            this.donViDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongSPDataGridViewTextBoxColumn
            // 
            this.soLuongSPDataGridViewTextBoxColumn.DataPropertyName = "SoLuongSP";
            this.soLuongSPDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongSPDataGridViewTextBoxColumn.Name = "soLuongSPDataGridViewTextBoxColumn";
            this.soLuongSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "Giá Nhập";
            this.giaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            this.giaNhapDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaNhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "Mã NCC";
            this.maNCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            this.maNCCDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNCCDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngayNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            this.ngayNhapDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayNhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayHetHanDataGridViewTextBoxColumn
            // 
            this.ngayHetHanDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHan";
            this.ngayHetHanDataGridViewTextBoxColumn.HeaderText = "Ngày hết hạn";
            this.ngayHetHanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHetHanDataGridViewTextBoxColumn.Name = "ngayHetHanDataGridViewTextBoxColumn";
            this.ngayHetHanDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayHetHanDataGridViewTextBoxColumn.Width = 125;
            // 
            // sANPHAMBindingSource1
            // 
            this.sANPHAMBindingSource1.DataMember = "SANPHAM";
            this.sANPHAMBindingSource1.DataSource = this.qLCHTraiCayDataSet1;
            // 
            // qLCHTraiCayDataSet1
            // 
            this.qLCHTraiCayDataSet1.DataSetName = "QLCHTraiCayDataSet1";
            this.qLCHTraiCayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.qLCHTraiCayDataSet;
            // 
            // qLCHTraiCayDataSet
            // 
            this.qLCHTraiCayDataSet.DataSetName = "QLCHTraiCayDataSet";
            this.qLCHTraiCayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(371, 84);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(329, 22);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lbTitle2
            // 
            this.lbTitle2.AutoSize = true;
            this.lbTitle2.BackColor = System.Drawing.Color.GreenYellow;
            this.lbTitle2.ForeColor = System.Drawing.Color.Black;
            this.lbTitle2.Location = new System.Drawing.Point(433, 97);
            this.lbTitle2.Name = "lbTitle2";
            this.lbTitle2.Size = new System.Drawing.Size(0, 16);
            this.lbTitle2.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.picTroVe);
            this.panel2.Controls.Add(this.picDangXuat);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 79);
            this.panel2.TabIndex = 8;
            // 
            // picTroVe
            // 
            this.picTroVe.Image = ((System.Drawing.Image)(resources.GetObject("picTroVe.Image")));
            this.picTroVe.Location = new System.Drawing.Point(25, 3);
            this.picTroVe.Name = "picTroVe";
            this.picTroVe.Size = new System.Drawing.Size(73, 64);
            this.picTroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTroVe.TabIndex = 17;
            this.picTroVe.TabStop = false;
            this.picTroVe.Click += new System.EventHandler(this.picTroVe_Click);
            // 
            // picDangXuat
            // 
            this.picDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("picDangXuat.Image")));
            this.picDangXuat.Location = new System.Drawing.Point(1029, 3);
            this.picDangXuat.Name = "picDangXuat";
            this.picDangXuat.Size = new System.Drawing.Size(73, 64);
            this.picDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDangXuat.TabIndex = 16;
            this.picDangXuat.TabStop = false;
            this.picDangXuat.Click += new System.EventHandler(this.picDangXuat_Click);
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // sANPHAMTableAdapter1
            // 
            this.sANPHAMTableAdapter1.ClearBeforeFill = true;
            // 
            // picXoa
            // 
            this.picXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picXoa.Enabled = false;
            this.picXoa.Image = ((System.Drawing.Image)(resources.GetObject("picXoa.Image")));
            this.picXoa.Location = new System.Drawing.Point(602, 0);
            this.picXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picXoa.Name = "picXoa";
            this.picXoa.Size = new System.Drawing.Size(108, 68);
            this.picXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXoa.TabIndex = 17;
            this.picXoa.TabStop = false;
            this.picXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(37, 72);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // picSua
            // 
            this.picSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picSua.Enabled = false;
            this.picSua.Image = ((System.Drawing.Image)(resources.GetObject("picSua.Image")));
            this.picSua.Location = new System.Drawing.Point(318, 0);
            this.picSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSua.Name = "picSua";
            this.picSua.Size = new System.Drawing.Size(98, 72);
            this.picSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSua.TabIndex = 19;
            this.picSua.TabStop = false;
            this.picSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(318, 73);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 34);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // picAdd
            // 
            this.picAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAdd.Enabled = false;
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(37, 2);
            this.picAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(98, 72);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 16;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(602, 69);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.panel1.Location = new System.Drawing.Point(317, 502);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 109);
            this.panel1.TabIndex = 0;
            // 
            // grp_ThongTinSP
            // 
            this.grp_ThongTinSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grp_ThongTinSP.Controls.Add(this.nb_soluong);
            this.grp_ThongTinSP.Controls.Add(this.txt_MaSP);
            this.grp_ThongTinSP.Controls.Add(this.dpOutDate);
            this.grp_ThongTinSP.Controls.Add(this.dpNhap);
            this.grp_ThongTinSP.Controls.Add(this.cbb_TenNCC);
            this.grp_ThongTinSP.Controls.Add(this.cbDonVi);
            this.grp_ThongTinSP.Controls.Add(this.lblMaNcc);
            this.grp_ThongTinSP.Controls.Add(this.lblMaSp);
            this.grp_ThongTinSP.Controls.Add(this.lblNgayHetHan);
            this.grp_ThongTinSP.Controls.Add(this.lblNgayNhap);
            this.grp_ThongTinSP.Controls.Add(this.lblGiaNhap);
            this.grp_ThongTinSP.Controls.Add(this.lblGiaBan);
            this.grp_ThongTinSP.Controls.Add(this.lblDonVi);
            this.grp_ThongTinSP.Controls.Add(this.lblSoLuong);
            this.grp_ThongTinSP.Controls.Add(this.lblTenSp);
            this.grp_ThongTinSP.Controls.Add(this.txtGiaBan);
            this.grp_ThongTinSP.Controls.Add(this.txtGiaNhap);
            this.grp_ThongTinSP.Controls.Add(this.txtTenSp);
            this.grp_ThongTinSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinSP.Location = new System.Drawing.Point(11, 85);
            this.grp_ThongTinSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_ThongTinSP.Name = "grp_ThongTinSP";
            this.grp_ThongTinSP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_ThongTinSP.Size = new System.Drawing.Size(301, 527);
            this.grp_ThongTinSP.TabIndex = 16;
            this.grp_ThongTinSP.TabStop = false;
            this.grp_ThongTinSP.Text = "Thông tin sản phẩm ";
            // 
            // nb_soluong
            // 
            this.nb_soluong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nb_soluong.Location = new System.Drawing.Point(140, 217);
            this.nb_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nb_soluong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nb_soluong.Name = "nb_soluong";
            this.nb_soluong.Size = new System.Drawing.Size(83, 30);
            this.nb_soluong.TabIndex = 32;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_MaSP.Location = new System.Drawing.Point(136, 44);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(143, 30);
            this.txt_MaSP.TabIndex = 31;
            // 
            // dpOutDate
            // 
            this.dpOutDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dpOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpOutDate.Location = new System.Drawing.Point(138, 486);
            this.dpOutDate.Name = "dpOutDate";
            this.dpOutDate.Size = new System.Drawing.Size(143, 30);
            this.dpOutDate.TabIndex = 30;
            // 
            // dpNhap
            // 
            this.dpNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dpNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpNhap.Location = new System.Drawing.Point(138, 434);
            this.dpNhap.Name = "dpNhap";
            this.dpNhap.Size = new System.Drawing.Size(143, 30);
            this.dpNhap.TabIndex = 29;
            // 
            // cbb_TenNCC
            // 
            this.cbb_TenNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbb_TenNCC.FormattingEnabled = true;
            this.cbb_TenNCC.Items.AddRange(new object[] {
            "Kg",
            "Gram"});
            this.cbb_TenNCC.Location = new System.Drawing.Point(140, 371);
            this.cbb_TenNCC.Name = "cbb_TenNCC";
            this.cbb_TenNCC.Size = new System.Drawing.Size(139, 31);
            this.cbb_TenNCC.TabIndex = 28;
            // 
            // cbDonVi
            // 
            this.cbDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDonVi.FormattingEnabled = true;
            this.cbDonVi.Items.AddRange(new object[] {
            "Kg",
            "Gram"});
            this.cbDonVi.Location = new System.Drawing.Point(136, 150);
            this.cbDonVi.Name = "cbDonVi";
            this.cbDonVi.Size = new System.Drawing.Size(83, 31);
            this.cbDonVi.TabIndex = 28;
            // 
            // lblMaNcc
            // 
            this.lblMaNcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaNcc.AutoSize = true;
            this.lblMaNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNcc.Location = new System.Drawing.Point(52, 386);
            this.lblMaNcc.Name = "lblMaNcc";
            this.lblMaNcc.Size = new System.Drawing.Size(73, 16);
            this.lblMaNcc.TabIndex = 26;
            this.lblMaNcc.Text = "Tên NCC:";
            // 
            // lblMaSp
            // 
            this.lblMaSp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaSp.AutoSize = true;
            this.lblMaSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSp.Location = new System.Drawing.Point(5, 50);
            this.lblMaSp.Name = "lblMaSp";
            this.lblMaSp.Size = new System.Drawing.Size(106, 16);
            this.lblMaSp.TabIndex = 27;
            this.lblMaSp.Text = "Mã Sản Phẩm:";
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHetHan.Location = new System.Drawing.Point(5, 489);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(108, 16);
            this.lblNgayHetHan.TabIndex = 25;
            this.lblNgayHetHan.Text = "Ngày Hết Hạn:";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(32, 443);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(89, 16);
            this.lblNgayNhap.TabIndex = 24;
            this.lblNgayNhap.Text = "Ngày Nhập:";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaNhap.Location = new System.Drawing.Point(43, 331);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(76, 16);
            this.lblGiaNhap.TabIndex = 23;
            this.lblGiaNhap.Text = "Giá Nhập:";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.Location = new System.Drawing.Point(52, 281);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(66, 16);
            this.lblGiaBan.TabIndex = 22;
            this.lblGiaBan.Text = "Giá Bán:";
            // 
            // lblDonVi
            // 
            this.lblDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonVi.Location = new System.Drawing.Point(61, 157);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(56, 16);
            this.lblDonVi.TabIndex = 21;
            this.lblDonVi.Text = "Đơn Vị:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(41, 222);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(76, 16);
            this.lblSoLuong.TabIndex = 20;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // lblTenSp
            // 
            this.lblTenSp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSp.Location = new System.Drawing.Point(5, 106);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(112, 16);
            this.lblTenSp.TabIndex = 19;
            this.lblTenSp.Text = "Tên Sản Phẩm:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGiaBan.Location = new System.Drawing.Point(136, 274);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(143, 30);
            this.txtGiaBan.TabIndex = 17;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGiaNhap.Location = new System.Drawing.Point(136, 325);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(143, 30);
            this.txtGiaNhap.TabIndex = 18;
            // 
            // txtTenSp
            // 
            this.txtTenSp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenSp.Location = new System.Drawing.Point(138, 99);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(143, 30);
            this.txtTenSp.TabIndex = 16;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1115, 619);
            this.Controls.Add(this.grp_ThongTinSP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbTitle2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dtgSanpham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSanPham";
            this.Text = "Sản Phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTroVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grp_ThongTinSP.ResumeLayout(false);
            this.grp_ThongTinSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_soluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dtgSanpham;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTitle2;
        private System.Windows.Forms.Panel panel2;
        private QLCHTraiCayDataSet qLCHTraiCayDataSet;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private QLCHTraiCayDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanDataGridViewTextBoxColumn;
        private QLCHTraiCayDataSet1 qLCHTraiCayDataSet1;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource1;
        private QLCHTraiCayDataSet1TableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter1;
        private System.Windows.Forms.PictureBox picTroVe;
        private System.Windows.Forms.PictureBox picDangXuat;
        private System.Windows.Forms.PictureBox picXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.PictureBox picSua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grp_ThongTinSP;
        private System.Windows.Forms.NumericUpDown nb_soluong;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.DateTimePicker dpOutDate;
        private System.Windows.Forms.DateTimePicker dpNhap;
        private System.Windows.Forms.ComboBox cbDonVi;
        private System.Windows.Forms.Label lblMaNcc;
        private System.Windows.Forms.Label lblMaSp;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenSp;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.ComboBox cbb_TenNCC;
    }
}