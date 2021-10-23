
namespace QuanLyNhaSach
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveKH = new System.Windows.Forms.Button();
            this.btnCloseKH = new System.Windows.Forms.Button();
            this.btnRefreshKH = new System.Windows.Forms.Button();
            this.btnDeleteKH = new System.Windows.Forms.Button();
            this.btnUpdateKH = new System.Windows.Forms.Button();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbSdtKH = new System.Windows.Forms.MaskedTextBox();
            this.dtpDobKH = new System.Windows.Forms.DateTimePicker();
            this.cboGenderKH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtTuoiKH = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnSaveKH);
            this.panel1.Controls.Add(this.btnCloseKH);
            this.panel1.Controls.Add(this.btnRefreshKH);
            this.panel1.Controls.Add(this.btnDeleteKH);
            this.panel1.Controls.Add(this.btnUpdateKH);
            this.panel1.Controls.Add(this.btnAddKH);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 94);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveKH
            // 
            this.btnSaveKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSaveKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveKH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveKH.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveKH.Image")));
            this.btnSaveKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveKH.Location = new System.Drawing.Point(455, 31);
            this.btnSaveKH.Name = "btnSaveKH";
            this.btnSaveKH.Padding = new System.Windows.Forms.Padding(5);
            this.btnSaveKH.Size = new System.Drawing.Size(117, 48);
            this.btnSaveKH.TabIndex = 5;
            this.btnSaveKH.Text = "Lưu";
            this.btnSaveKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveKH.UseVisualStyleBackColor = false;
            this.btnSaveKH.Click += new System.EventHandler(this.btnSaveKH_Click);
            // 
            // btnCloseKH
            // 
            this.btnCloseKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCloseKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCloseKH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseKH.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseKH.Image")));
            this.btnCloseKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloseKH.Location = new System.Drawing.Point(735, 31);
            this.btnCloseKH.Name = "btnCloseKH";
            this.btnCloseKH.Padding = new System.Windows.Forms.Padding(5);
            this.btnCloseKH.Size = new System.Drawing.Size(117, 48);
            this.btnCloseKH.TabIndex = 4;
            this.btnCloseKH.Text = "Đóng";
            this.btnCloseKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseKH.UseVisualStyleBackColor = false;
            this.btnCloseKH.Click += new System.EventHandler(this.btnCloseKH_Click);
            // 
            // btnRefreshKH
            // 
            this.btnRefreshKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRefreshKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefreshKH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshKH.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshKH.Image")));
            this.btnRefreshKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefreshKH.Location = new System.Drawing.Point(590, 31);
            this.btnRefreshKH.Name = "btnRefreshKH";
            this.btnRefreshKH.Padding = new System.Windows.Forms.Padding(5);
            this.btnRefreshKH.Size = new System.Drawing.Size(117, 48);
            this.btnRefreshKH.TabIndex = 3;
            this.btnRefreshKH.Text = "Bỏ qua";
            this.btnRefreshKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshKH.UseVisualStyleBackColor = false;
            this.btnRefreshKH.Click += new System.EventHandler(this.btnRefreshKH_Click);
            // 
            // btnDeleteKH
            // 
            this.btnDeleteKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDeleteKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteKH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteKH.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteKH.Image")));
            this.btnDeleteKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteKH.Location = new System.Drawing.Point(300, 31);
            this.btnDeleteKH.Name = "btnDeleteKH";
            this.btnDeleteKH.Padding = new System.Windows.Forms.Padding(5);
            this.btnDeleteKH.Size = new System.Drawing.Size(117, 48);
            this.btnDeleteKH.TabIndex = 2;
            this.btnDeleteKH.Text = "Xoá";
            this.btnDeleteKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteKH.UseVisualStyleBackColor = false;
            this.btnDeleteKH.Click += new System.EventHandler(this.btnDeleteKH_Click);
            // 
            // btnUpdateKH
            // 
            this.btnUpdateKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnUpdateKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateKH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateKH.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateKH.Image")));
            this.btnUpdateKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateKH.Location = new System.Drawing.Point(155, 31);
            this.btnUpdateKH.Name = "btnUpdateKH";
            this.btnUpdateKH.Padding = new System.Windows.Forms.Padding(5);
            this.btnUpdateKH.Size = new System.Drawing.Size(117, 48);
            this.btnUpdateKH.TabIndex = 1;
            this.btnUpdateKH.Text = "Sửa";
            this.btnUpdateKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateKH.UseVisualStyleBackColor = false;
            this.btnUpdateKH.Click += new System.EventHandler(this.btnUpdateKH_Click);
            // 
            // btnAddKH
            // 
            this.btnAddKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddKH.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKH.Image = ((System.Drawing.Image)(resources.GetObject("btnAddKH.Image")));
            this.btnAddKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddKH.Location = new System.Drawing.Point(12, 31);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddKH.Size = new System.Drawing.Size(117, 48);
            this.btnAddKH.TabIndex = 0;
            this.btnAddKH.Text = "Thêm";
            this.btnAddKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddKH.UseVisualStyleBackColor = false;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 217);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(794, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mtbSdtKH);
            this.groupBox1.Controls.Add(this.dtpDobKH);
            this.groupBox1.Controls.Add(this.cboGenderKH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDiaChiKH);
            this.groupBox1.Controls.Add(this.txtTuoiKH);
            this.groupBox1.Controls.Add(this.txtHoTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // mtbSdtKH
            // 
            this.mtbSdtKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbSdtKH.Location = new System.Drawing.Point(573, 87);
            this.mtbSdtKH.Name = "mtbSdtKH";
            this.mtbSdtKH.Size = new System.Drawing.Size(257, 26);
            this.mtbSdtKH.TabIndex = 22;
            this.mtbSdtKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbSdtKH_KeyUp);
            // 
            // dtpDobKH
            // 
            this.dtpDobKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDobKH.CustomFormat = "YYYY/MM/dd";
            this.dtpDobKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDobKH.Location = new System.Drawing.Point(573, 53);
            this.dtpDobKH.Name = "dtpDobKH";
            this.dtpDobKH.Size = new System.Drawing.Size(257, 26);
            this.dtpDobKH.TabIndex = 19;
            this.dtpDobKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtpDobKH_KeyUp);
            // 
            // cboGenderKH
            // 
            this.cboGenderKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGenderKH.FormattingEnabled = true;
            this.cboGenderKH.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cboGenderKH.Location = new System.Drawing.Point(573, 19);
            this.cboGenderKH.Name = "cboGenderKH";
            this.cboGenderKH.Size = new System.Drawing.Size(257, 27);
            this.cboGenderKH.TabIndex = 18;
            this.cboGenderKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboGenderKH_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "SĐT:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Giới tính:";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(95, 121);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(257, 26);
            this.txtDiaChiKH.TabIndex = 10;
            this.txtDiaChiKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiaChiKH_KeyUp);
            // 
            // txtTuoiKH
            // 
            this.txtTuoiKH.Location = new System.Drawing.Point(95, 87);
            this.txtTuoiKH.Name = "txtTuoiKH";
            this.txtTuoiKH.Size = new System.Drawing.Size(257, 26);
            this.txtTuoiKH.TabIndex = 9;
            this.txtTuoiKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTuoiKH_KeyUp);
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(95, 53);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(257, 26);
            this.txtHoTenKH.TabIndex = 8;
            this.txtHoTenKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHoTenKH_KeyUp);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(95, 19);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(257, 26);
            this.txtMaKH.TabIndex = 7;
            this.txtMaKH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tuổi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(255, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 217);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(864, 350);
            this.dgvCustomer.TabIndex = 2;
            this.dgvCustomer.Click += new System.EventHandler(this.dgvCustomer_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 661);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtTuoiKH;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDobKH;
        private System.Windows.Forms.ComboBox cboGenderKH;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnCloseKH;
        private System.Windows.Forms.Button btnRefreshKH;
        private System.Windows.Forms.Button btnDeleteKH;
        private System.Windows.Forms.Button btnUpdateKH;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.MaskedTextBox mtbSdtKH;
        private System.Windows.Forms.Button btnSaveKH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}