namespace WindowsFormsApp3
{
    partial class KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.CbLoaiKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.BtnThem = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel7 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.BtnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenKH_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaKH_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ngaymotaikhoan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2GradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Controls.Add(this.txtHoTen);
            this.guna2GradientPanel1.Controls.Add(this.txtMaKH);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(176)))), ((int)(((byte)(168)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(176)))), ((int)(((byte)(168)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(33, 29);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(404, 149);
            this.guna2GradientPanel1.TabIndex = 43;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.image_removebg_preview__2_;
            this.guna2GradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(9, 18);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(132, 103);
            this.guna2GradientPanel2.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 11;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(149, 64);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "Họ Tên";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(204, 57);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderRadius = 8;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Location = new System.Drawing.Point(181, 23);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PlaceholderText = "Mã khách hàng";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(142, 25);
            this.txtMaKH.TabIndex = 3;
            this.txtMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbLoaiKH
            // 
            this.CbLoaiKH.BackColor = System.Drawing.Color.Transparent;
            this.CbLoaiKH.BorderRadius = 11;
            this.CbLoaiKH.Cursor = System.Windows.Forms.Cursors.No;
            this.CbLoaiKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbLoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLoaiKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbLoaiKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbLoaiKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbLoaiKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbLoaiKH.ItemHeight = 30;
            this.CbLoaiKH.Location = new System.Drawing.Point(199, 104);
            this.CbLoaiKH.Margin = new System.Windows.Forms.Padding(4);
            this.CbLoaiKH.Name = "CbLoaiKH";
            this.CbLoaiKH.Size = new System.Drawing.Size(240, 36);
            this.CbLoaiKH.TabIndex = 25;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderRadius = 11;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(199, 14);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(240, 31);
            this.txtSDT.TabIndex = 19;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnXoa
            // 
            this.BtnXoa.BorderRadius = 10;
            this.BtnXoa.CustomizableEdges.BottomLeft = false;
            this.BtnXoa.CustomizableEdges.TopLeft = false;
            this.BtnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(125)))));
            this.BtnXoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.Color.White;
            this.BtnXoa.Location = new System.Drawing.Point(290, 205);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(140, 55);
            this.BtnXoa.TabIndex = 49;
            this.BtnXoa.Text = "Xóa KH";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.BorderRadius = 10;
            this.BtnThem.CustomizableEdges.BottomRight = false;
            this.BtnThem.CustomizableEdges.TopRight = false;
            this.BtnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(125)))));
            this.BtnThem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.ForeColor = System.Drawing.Color.White;
            this.BtnThem.Location = new System.Drawing.Point(18, 205);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(142, 55);
            this.BtnThem.TabIndex = 50;
            this.BtnThem.Text = "Thêm KH";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(125)))));
            this.BtnSua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.ForeColor = System.Drawing.Color.White;
            this.BtnSua.Location = new System.Drawing.Point(160, 205);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(130, 55);
            this.BtnSua.TabIndex = 48;
            this.BtnSua.Text = "Sửa KH";
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // guna2GradientPanel7
            // 
            this.guna2GradientPanel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel7.BorderRadius = 20;
            this.guna2GradientPanel7.Controls.Add(this.BtnTimKiem);
            this.guna2GradientPanel7.Controls.Add(this.txtTenKH_TimKiem);
            this.guna2GradientPanel7.Controls.Add(this.txtMaKH_TimKiem);
            this.guna2GradientPanel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(176)))), ((int)(((byte)(168)))));
            this.guna2GradientPanel7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(176)))), ((int)(((byte)(168)))));
            this.guna2GradientPanel7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel7.Location = new System.Drawing.Point(33, 291);
            this.guna2GradientPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel7.Name = "guna2GradientPanel7";
            this.guna2GradientPanel7.Size = new System.Drawing.Size(690, 54);
            this.guna2GradientPanel7.TabIndex = 51;
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.BorderRadius = 14;
            this.BtnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(125)))));
            this.BtnTimKiem.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.BtnTimKiem.ForeColor = System.Drawing.Color.White;
            this.BtnTimKiem.Location = new System.Drawing.Point(439, 10);
            this.BtnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(226, 34);
            this.BtnTimKiem.TabIndex = 15;
            this.BtnTimKiem.Text = "Tìm Kiếm";
            this.BtnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // txtTenKH_TimKiem
            // 
            this.txtTenKH_TimKiem.BorderRadius = 14;
            this.txtTenKH_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH_TimKiem.DefaultText = "";
            this.txtTenKH_TimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenKH_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH_TimKiem.Location = new System.Drawing.Point(226, 10);
            this.txtTenKH_TimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenKH_TimKiem.Name = "txtTenKH_TimKiem";
            this.txtTenKH_TimKiem.PlaceholderText = "Họ Tên";
            this.txtTenKH_TimKiem.SelectedText = "";
            this.txtTenKH_TimKiem.Size = new System.Drawing.Size(190, 34);
            this.txtTenKH_TimKiem.TabIndex = 6;
            this.txtTenKH_TimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaKH_TimKiem
            // 
            this.txtMaKH_TimKiem.BorderRadius = 14;
            this.txtMaKH_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH_TimKiem.DefaultText = "";
            this.txtMaKH_TimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaKH_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH_TimKiem.Location = new System.Drawing.Point(19, 10);
            this.txtMaKH_TimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaKH_TimKiem.Name = "txtMaKH_TimKiem";
            this.txtMaKH_TimKiem.PlaceholderText = "Mã Khách hàng";
            this.txtMaKH_TimKiem.SelectedText = "";
            this.txtMaKH_TimKiem.Size = new System.Drawing.Size(196, 34);
            this.txtMaKH_TimKiem.TabIndex = 5;
            this.txtMaKH_TimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(176)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhachhang,
            this.hoten,
            this.phone,
            this.email,
            this.diachi,
            this.loaiKH,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(176)))), ((int)(((byte)(168)))));
            this.dataGridView1.Location = new System.Drawing.Point(28, 354);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(923, 171);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(176)))), ((int)(((byte)(168)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(176)))), ((int)(((byte)(168)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // makhachhang
            // 
            this.makhachhang.DataPropertyName = "customer_id";
            this.makhachhang.HeaderText = "Mã KH";
            this.makhachhang.MinimumWidth = 8;
            this.makhachhang.Name = "makhachhang";
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "name";
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 8;
            this.phone.Name = "phone";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "address";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 8;
            this.diachi.Name = "diachi";
            // 
            // loaiKH
            // 
            this.loaiKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loaiKH.DataPropertyName = "type";
            this.loaiKH.HeaderText = "Loại KH";
            this.loaiKH.MinimumWidth = 8;
            this.loaiKH.Name = "loaiKH";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "created_at";
            this.Column1.HeaderText = "Ngày mở tài khoản";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // BtnReset
            // 
            this.BtnReset.BorderRadius = 10;
            this.BtnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(730, 290);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(192, 55);
            this.BtnReset.TabIndex = 53;
            this.BtnReset.Text = "RESET";
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel3.BorderRadius = 20;
            this.guna2GradientPanel3.Controls.Add(this.ngaymotaikhoan);
            this.guna2GradientPanel3.Controls.Add(this.label5);
            this.guna2GradientPanel3.Controls.Add(this.label4);
            this.guna2GradientPanel3.Controls.Add(this.label3);
            this.guna2GradientPanel3.Controls.Add(this.label2);
            this.guna2GradientPanel3.Controls.Add(this.label1);
            this.guna2GradientPanel3.Controls.Add(this.txtDiaChi);
            this.guna2GradientPanel3.Controls.Add(this.txtEmail);
            this.guna2GradientPanel3.Controls.Add(this.CbLoaiKH);
            this.guna2GradientPanel3.Controls.Add(this.txtSDT);
            this.guna2GradientPanel3.CustomizableEdges.BottomLeft = false;
            this.guna2GradientPanel3.CustomizableEdges.BottomRight = false;
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(176)))), ((int)(((byte)(168)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(176)))), ((int)(((byte)(168)))));
            this.guna2GradientPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel3.Location = new System.Drawing.Point(444, 29);
            this.guna2GradientPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Size = new System.Drawing.Size(469, 238);
            this.guna2GradientPanel3.TabIndex = 45;
            // 
            // ngaymotaikhoan
            // 
            this.ngaymotaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.ngaymotaikhoan.BorderRadius = 10;
            this.ngaymotaikhoan.Checked = true;
            this.ngaymotaikhoan.CustomFormat = "dd/MM/yyyy";
            this.ngaymotaikhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(168)))), ((int)(((byte)(125)))));
            this.ngaymotaikhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaymotaikhoan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaymotaikhoan.Location = new System.Drawing.Point(199, 199);
            this.ngaymotaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.ngaymotaikhoan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngaymotaikhoan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngaymotaikhoan.Name = "ngaymotaikhoan";
            this.ngaymotaikhoan.Size = new System.Drawing.Size(240, 32);
            this.ngaymotaikhoan.TabIndex = 38;
            this.ngaymotaikhoan.Value = new System.DateTime(2025, 3, 26, 1, 51, 34, 921);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ngày mở tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Loại khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Số điện thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderRadius = 11;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(199, 157);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(240, 31);
            this.txtDiaChi.TabIndex = 28;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 11;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(199, 64);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(240, 31);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 538);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2GradientPanel7);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.guna2GradientPanel3);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhachHang";
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2GradientPanel3.ResumeLayout(false);
            this.guna2GradientPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private Guna.UI2.WinForms.Guna2ComboBox CbLoaiKH;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2Button BtnXoa;
        private Guna.UI2.WinForms.Guna2Button BtnThem;
        private Guna.UI2.WinForms.Guna2Button BtnSua;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel7;
        private Guna.UI2.WinForms.Guna2Button BtnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH_TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH_TimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button BtnReset;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker ngaymotaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

