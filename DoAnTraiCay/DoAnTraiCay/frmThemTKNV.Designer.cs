namespace DoAnTraiCay
{
    partial class frmThemTKNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTKNV));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtgTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tAIKHOANNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHTraiCayDataSet2 = new DoAnTraiCay.QLCHTraiCayDataSet2();
            this.tAIKHOANNVTableAdapter = new DoAnTraiCay.QLCHTraiCayDataSet2TableAdapters.TAIKHOANNVTableAdapter();
            this.lblManvTKNV = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.txtTKNV = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtMKNV = new System.Windows.Forms.TextBox();
            this.lblVaitro = new System.Windows.Forms.Label();
            this.cb_Vaitro = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.picSua = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cbMaTKNV = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 79);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(983, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnDangXuatTKNV_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnTroVeTKNV_Click);
            // 
            // dtgTaiKhoan
            // 
            this.dtgTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTaiKhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTaiKhoan.Location = new System.Drawing.Point(311, 85);
            this.dtgTaiKhoan.Name = "dtgTaiKhoan";
            this.dtgTaiKhoan.ReadOnly = true;
            this.dtgTaiKhoan.RowHeadersWidth = 51;
            this.dtgTaiKhoan.RowTemplate.Height = 24;
            this.dtgTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTaiKhoan.Size = new System.Drawing.Size(766, 330);
            this.dtgTaiKhoan.TabIndex = 2;
            this.dtgTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTaiKhoan_CellClick);
            // 
            // tAIKHOANNVBindingSource
            // 
            this.tAIKHOANNVBindingSource.DataMember = "TAIKHOANNV";
            this.tAIKHOANNVBindingSource.DataSource = this.qLCHTraiCayDataSet2;
            // 
            // qLCHTraiCayDataSet2
            // 
            this.qLCHTraiCayDataSet2.DataSetName = "QLCHTraiCayDataSet2";
            this.qLCHTraiCayDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANNVTableAdapter
            // 
            this.tAIKHOANNVTableAdapter.ClearBeforeFill = true;
            // 
            // lblManvTKNV
            // 
            this.lblManvTKNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblManvTKNV.AutoSize = true;
            this.lblManvTKNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManvTKNV.Location = new System.Drawing.Point(30, 49);
            this.lblManvTKNV.Name = "lblManvTKNV";
            this.lblManvTKNV.Size = new System.Drawing.Size(57, 16);
            this.lblManvTKNV.TabIndex = 0;
            this.lblManvTKNV.Text = "Mã NV:";
            // 
            // lblTK
            // 
            this.lblTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.Location = new System.Drawing.Point(7, 100);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(80, 16);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "Tài khoản:";
            // 
            // txtTKNV
            // 
            this.txtTKNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTKNV.Location = new System.Drawing.Point(93, 94);
            this.txtTKNV.Name = "txtTKNV";
            this.txtTKNV.Size = new System.Drawing.Size(192, 22);
            this.txtTKNV.TabIndex = 1;
            // 
            // lblMK
            // 
            this.lblMK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(14, 154);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(73, 16);
            this.lblMK.TabIndex = 0;
            this.lblMK.Text = "Mật khẩu:";
            // 
            // txtMKNV
            // 
            this.txtMKNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMKNV.Location = new System.Drawing.Point(93, 148);
            this.txtMKNV.Name = "txtMKNV";
            this.txtMKNV.Size = new System.Drawing.Size(192, 22);
            this.txtMKNV.TabIndex = 1;
            // 
            // lblVaitro
            // 
            this.lblVaitro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVaitro.AutoSize = true;
            this.lblVaitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaitro.Location = new System.Drawing.Point(31, 212);
            this.lblVaitro.Name = "lblVaitro";
            this.lblVaitro.Size = new System.Drawing.Size(56, 16);
            this.lblVaitro.TabIndex = 0;
            this.lblVaitro.Text = "Vai trò:";
            // 
            // cb_Vaitro
            // 
            this.cb_Vaitro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_Vaitro.FormattingEnabled = true;
            this.cb_Vaitro.Items.AddRange(new object[] {
            "Admin",
            "NhanVien"});
            this.cb_Vaitro.Location = new System.Drawing.Point(94, 203);
            this.cb_Vaitro.Name = "cb_Vaitro";
            this.cb_Vaitro.Size = new System.Drawing.Size(156, 24);
            this.cb_Vaitro.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.cbMaTKNV);
            this.panel1.Controls.Add(this.cb_Vaitro);
            this.panel1.Controls.Add(this.lblVaitro);
            this.panel1.Controls.Add(this.txtMKNV);
            this.panel1.Controls.Add(this.lblMK);
            this.panel1.Controls.Add(this.txtTKNV);
            this.panel1.Controls.Add(this.lblTK);
            this.panel1.Controls.Add(this.lblManvTKNV);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 413);
            this.panel1.TabIndex = 3;
            // 
            // picAdd
            // 
            this.picAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAdd.Enabled = false;
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(37, 3);
            this.picAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(98, 55);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 16;
            this.picAdd.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(37, 59);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThemTKNV_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.picAdd);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.picSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(311, 419);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 93);
            this.panel3.TabIndex = 18;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(581, 59);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoaTKNV_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(308, 61);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 32);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSuaTKNV_Click);
            // 
            // picSua
            // 
            this.picSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picSua.Enabled = false;
            this.picSua.Image = ((System.Drawing.Image)(resources.GetObject("picSua.Image")));
            this.picSua.Location = new System.Drawing.Point(308, 3);
            this.picSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSua.Name = "picSua";
            this.picSua.Size = new System.Drawing.Size(98, 54);
            this.picSua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSua.TabIndex = 19;
            this.picSua.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(581, 3);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // cbMaTKNV
            // 
            this.cbMaTKNV.FormattingEnabled = true;
            this.cbMaTKNV.Location = new System.Drawing.Point(93, 49);
            this.cbMaTKNV.Name = "cbMaTKNV";
            this.cbMaTKNV.Size = new System.Drawing.Size(192, 24);
            this.cbMaTKNV.TabIndex = 4;
            // 
            // frmThemTKNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 508);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgTaiKhoan);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemTKNV";
            this.Text = "Thêm Tài Khoản Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThemTKNV_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHTraiCayDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgTaiKhoan;
        private QLCHTraiCayDataSet2 qLCHTraiCayDataSet2;
        private System.Windows.Forms.BindingSource tAIKHOANNVBindingSource;
        private QLCHTraiCayDataSet2TableAdapters.TAIKHOANNVTableAdapter tAIKHOANNVTableAdapter;
        private System.Windows.Forms.Label lblManvTKNV;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.TextBox txtTKNV;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtMKNV;
        private System.Windows.Forms.Label lblVaitro;
        private System.Windows.Forms.ComboBox cb_Vaitro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.PictureBox picSua;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbMaTKNV;
    }
}