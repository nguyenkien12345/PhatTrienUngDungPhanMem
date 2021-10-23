
namespace QuanLyNhaSach
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvProduct = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveSP = new System.Windows.Forms.Button();
            this.btnCloseSP = new System.Windows.Forms.Button();
            this.btnRefreshSP = new System.Windows.Forms.Button();
            this.btnDeleteSP = new System.Windows.Forms.Button();
            this.btnUpdateSP = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.txtXuatXuSP = new System.Windows.Forms.TextBox();
            this.txtDonViSP = new System.Windows.Forms.TextBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoTaSP = new System.Windows.Forms.TextBox();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(222, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(891, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 610);
            this.panel2.TabIndex = 1;
            // 
            // tvProduct
            // 
            this.tvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvProduct.Location = new System.Drawing.Point(0, 0);
            this.tvProduct.Name = "tvProduct";
            this.tvProduct.Size = new System.Drawing.Size(262, 610);
            this.tvProduct.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(262, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 327);
            this.panel4.TabIndex = 3;
            // 
            // lvProduct
            // 
            this.lvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.GridLines = true;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(0, 0);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(702, 327);
            this.lvProduct.TabIndex = 0;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.SelectedIndexChanged += new System.EventHandler(this.lvProduct_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã ";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá tiền";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mô tả ";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn vị tính";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Xuất xứ";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Danh mục";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(262, 408);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 283);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSaveSP);
            this.groupBox1.Controls.Add(this.btnCloseSP);
            this.groupBox1.Controls.Add(this.btnRefreshSP);
            this.groupBox1.Controls.Add(this.btnDeleteSP);
            this.groupBox1.Controls.Add(this.btnUpdateSP);
            this.groupBox1.Controls.Add(this.btnAddSP);
            this.groupBox1.Controls.Add(this.txtXuatXuSP);
            this.groupBox1.Controls.Add(this.txtDonViSP);
            this.groupBox1.Controls.Add(this.cboLoaiSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMoTaSP);
            this.groupBox1.Controls.Add(this.txtGiaSP);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnSaveSP
            // 
            this.btnSaveSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSaveSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveSP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSP.Image")));
            this.btnSaveSP.Location = new System.Drawing.Point(354, 200);
            this.btnSaveSP.Name = "btnSaveSP";
            this.btnSaveSP.Padding = new System.Windows.Forms.Padding(5);
            this.btnSaveSP.Size = new System.Drawing.Size(111, 47);
            this.btnSaveSP.TabIndex = 72;
            this.btnSaveSP.Text = "Lưu";
            this.btnSaveSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveSP.UseVisualStyleBackColor = false;
            this.btnSaveSP.Click += new System.EventHandler(this.btnSaveSP_Click);
            // 
            // btnCloseSP
            // 
            this.btnCloseSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCloseSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCloseSP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSP.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseSP.Image")));
            this.btnCloseSP.Location = new System.Drawing.Point(588, 200);
            this.btnCloseSP.Name = "btnCloseSP";
            this.btnCloseSP.Padding = new System.Windows.Forms.Padding(5);
            this.btnCloseSP.Size = new System.Drawing.Size(111, 47);
            this.btnCloseSP.TabIndex = 71;
            this.btnCloseSP.Text = "Đóng";
            this.btnCloseSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseSP.UseVisualStyleBackColor = false;
            this.btnCloseSP.Click += new System.EventHandler(this.btnCloseSP_Click);
            // 
            // btnRefreshSP
            // 
            this.btnRefreshSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRefreshSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefreshSP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSP.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshSP.Image")));
            this.btnRefreshSP.Location = new System.Drawing.Point(471, 200);
            this.btnRefreshSP.Name = "btnRefreshSP";
            this.btnRefreshSP.Padding = new System.Windows.Forms.Padding(5);
            this.btnRefreshSP.Size = new System.Drawing.Size(111, 47);
            this.btnRefreshSP.TabIndex = 70;
            this.btnRefreshSP.Text = "Bỏ qua";
            this.btnRefreshSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshSP.UseVisualStyleBackColor = false;
            this.btnRefreshSP.Click += new System.EventHandler(this.btnRefreshSP_Click);
            // 
            // btnDeleteSP
            // 
            this.btnDeleteSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDeleteSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDeleteSP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSP.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSP.Image")));
            this.btnDeleteSP.Location = new System.Drawing.Point(237, 200);
            this.btnDeleteSP.Name = "btnDeleteSP";
            this.btnDeleteSP.Padding = new System.Windows.Forms.Padding(5);
            this.btnDeleteSP.Size = new System.Drawing.Size(111, 47);
            this.btnDeleteSP.TabIndex = 69;
            this.btnDeleteSP.Text = "Xoá";
            this.btnDeleteSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteSP.UseVisualStyleBackColor = false;
            this.btnDeleteSP.Click += new System.EventHandler(this.btnDeleteSP_Click);
            // 
            // btnUpdateSP
            // 
            this.btnUpdateSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnUpdateSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateSP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSP.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSP.Image")));
            this.btnUpdateSP.Location = new System.Drawing.Point(120, 200);
            this.btnUpdateSP.Name = "btnUpdateSP";
            this.btnUpdateSP.Padding = new System.Windows.Forms.Padding(5);
            this.btnUpdateSP.Size = new System.Drawing.Size(111, 47);
            this.btnUpdateSP.TabIndex = 68;
            this.btnUpdateSP.Text = "Sửa";
            this.btnUpdateSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateSP.UseVisualStyleBackColor = false;
            this.btnUpdateSP.Click += new System.EventHandler(this.btnUpdateSP_Click);
            // 
            // btnAddSP
            // 
            this.btnAddSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddSP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSP.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSP.Image")));
            this.btnAddSP.Location = new System.Drawing.Point(3, 200);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddSP.Size = new System.Drawing.Size(111, 47);
            this.btnAddSP.TabIndex = 67;
            this.btnAddSP.Text = "Thêm";
            this.btnAddSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSP.UseVisualStyleBackColor = false;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // txtXuatXuSP
            // 
            this.txtXuatXuSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXuatXuSP.Location = new System.Drawing.Point(450, 89);
            this.txtXuatXuSP.Name = "txtXuatXuSP";
            this.txtXuatXuSP.Size = new System.Drawing.Size(240, 26);
            this.txtXuatXuSP.TabIndex = 66;
            // 
            // txtDonViSP
            // 
            this.txtDonViSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonViSP.Location = new System.Drawing.Point(450, 55);
            this.txtDonViSP.Name = "txtDonViSP";
            this.txtDonViSP.Size = new System.Drawing.Size(240, 26);
            this.txtDonViSP.TabIndex = 65;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(451, 123);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(240, 27);
            this.cboLoaiSP.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "Xuất xứ:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 60;
            this.label8.Tag = "";
            this.label8.Text = "Loại:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(373, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 59;
            this.label9.Text = "Đơn vị:";
            // 
            // txtMoTaSP
            // 
            this.txtMoTaSP.Location = new System.Drawing.Point(94, 157);
            this.txtMoTaSP.Name = "txtMoTaSP";
            this.txtMoTaSP.Size = new System.Drawing.Size(240, 26);
            this.txtMoTaSP.TabIndex = 58;
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Location = new System.Drawing.Point(94, 123);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(240, 26);
            this.txtGiaSP.TabIndex = 57;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(94, 89);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(240, 26);
            this.txtTenSP.TabIndex = 56;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(94, 55);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(240, 26);
            this.txtMaSP.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Mô tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mã:";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 691);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoTaSP;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXuatXuSP;
        private System.Windows.Forms.TextBox txtDonViSP;
        private System.Windows.Forms.Button btnSaveSP;
        private System.Windows.Forms.Button btnCloseSP;
        private System.Windows.Forms.Button btnRefreshSP;
        private System.Windows.Forms.Button btnDeleteSP;
        private System.Windows.Forms.Button btnUpdateSP;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TreeView tvProduct;
    }
}