namespace PBL3
{
    partial class _mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_mainForm));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureUser = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.iconButton11 = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butQuanLi = new FontAwesome.Sharp.IconButton();
            this.butKhachHang = new FontAwesome.Sharp.IconButton();
            this.butSapXep = new FontAwesome.Sharp.IconButton();
            this.butInHoaDon = new FontAwesome.Sharp.IconButton();
            this.butExit = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel5ButEnd = new System.Windows.Forms.Panel();
            this.butDatPhong = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.dropMenuQuanLi = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.quảnLíTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíĐồThấtLạcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropMenuBaoCao = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.báoCáoTổngHợpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoCôngNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropMenuUser = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel5ButEnd.SuspendLayout();
            this.dropMenuQuanLi.SuspendLayout();
            this.dropMenuBaoCao.SuspendLayout();
            this.dropMenuUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.panelTitleBar.Controls.Add(this.pictureUser);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.iconButton11);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(988, 100);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.Resize += new System.EventHandler(this.Form1_Resize);
            // 
            // pictureUser
            // 
            this.pictureUser.AllowFocused = false;
            this.pictureUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureUser.AutoSizeHeight = true;
            this.pictureUser.BorderRadius = 28;
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.IsCircle = true;
            this.pictureUser.Location = new System.Drawing.Point(911, 30);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(57, 57);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 5;
            this.pictureUser.TabStop = false;
            this.pictureUser.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.pictureUser.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleChildForm.Location = new System.Drawing.Point(88, 32);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(57, 22);
            this.lblTitleChildForm.TabIndex = 4;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.iconCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(7, 12);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(75, 66);
            this.iconCurrentChildForm.TabIndex = 3;
            this.iconCurrentChildForm.UseVisualStyleBackColor = true;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // iconButton11
            // 
            this.iconButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton11.FlatAppearance.BorderSize = 0;
            this.iconButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton11.ForeColor = System.Drawing.Color.Blue;
            this.iconButton11.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton11.IconColor = System.Drawing.Color.Black;
            this.iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton11.Location = new System.Drawing.Point(959, 0);
            this.iconButton11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton11.Name = "iconButton11";
            this.iconButton11.Size = new System.Drawing.Size(29, 30);
            this.iconButton11.TabIndex = 2;
            this.iconButton11.Text = "O";
            this.iconButton11.UseVisualStyleBackColor = true;
            this.iconButton11.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.Location = new System.Drawing.Point(921, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(29, 30);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.Location = new System.Drawing.Point(887, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 30);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(988, 583);
            this.panelDesktop.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.Location = new System.Drawing.Point(140, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 50);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Tag = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // butQuanLi
            // 
            this.butQuanLi.Dock = System.Windows.Forms.DockStyle.Top;
            this.butQuanLi.FlatAppearance.BorderSize = 0;
            this.butQuanLi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butQuanLi.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQuanLi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butQuanLi.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.butQuanLi.IconColor = System.Drawing.Color.White;
            this.butQuanLi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butQuanLi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butQuanLi.Location = new System.Drawing.Point(0, 100);
            this.butQuanLi.Margin = new System.Windows.Forms.Padding(1);
            this.butQuanLi.Name = "butQuanLi";
            this.butQuanLi.Size = new System.Drawing.Size(200, 50);
            this.butQuanLi.TabIndex = 1;
            this.butQuanLi.Tag = "Quản Lí Nhân Viên";
            this.butQuanLi.Text = "Quản Lí Nhân Viên";
            this.butQuanLi.UseVisualStyleBackColor = true;
            this.butQuanLi.Click += new System.EventHandler(this.butQuanLi_Click);
            // 
            // butKhachHang
            // 
            this.butKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.butKhachHang.FlatAppearance.BorderSize = 0;
            this.butKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butKhachHang.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butKhachHang.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.butKhachHang.IconColor = System.Drawing.Color.White;
            this.butKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKhachHang.Location = new System.Drawing.Point(0, 0);
            this.butKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butKhachHang.Name = "butKhachHang";
            this.butKhachHang.Size = new System.Drawing.Size(200, 60);
            this.butKhachHang.TabIndex = 2;
            this.butKhachHang.Tag = "Khách Hàng";
            this.butKhachHang.Text = "Khách Hàng";
            this.butKhachHang.UseVisualStyleBackColor = true;
            this.butKhachHang.Click += new System.EventHandler(this.butKhachHang_Click);
            // 
            // butSapXep
            // 
            this.butSapXep.Dock = System.Windows.Forms.DockStyle.Top;
            this.butSapXep.FlatAppearance.BorderSize = 0;
            this.butSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSapXep.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSapXep.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butSapXep.IconChar = FontAwesome.Sharp.IconChar.SortAmountDown;
            this.butSapXep.IconColor = System.Drawing.Color.White;
            this.butSapXep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butSapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSapXep.Location = new System.Drawing.Point(0, 110);
            this.butSapXep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butSapXep.Name = "butSapXep";
            this.butSapXep.Size = new System.Drawing.Size(200, 50);
            this.butSapXep.TabIndex = 5;
            this.butSapXep.Tag = "Lọc Sắp Xếp";
            this.butSapXep.Text = "Lọc Sắp Xếp";
            this.butSapXep.UseVisualStyleBackColor = true;
            this.butSapXep.Click += new System.EventHandler(this.butSapXep_Click);
            // 
            // butInHoaDon
            // 
            this.butInHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.butInHoaDon.FlatAppearance.BorderSize = 0;
            this.butInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butInHoaDon.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInHoaDon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butInHoaDon.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.butInHoaDon.IconColor = System.Drawing.Color.White;
            this.butInHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butInHoaDon.Location = new System.Drawing.Point(0, 220);
            this.butInHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butInHoaDon.Name = "butInHoaDon";
            this.butInHoaDon.Size = new System.Drawing.Size(200, 50);
            this.butInHoaDon.TabIndex = 6;
            this.butInHoaDon.Tag = "In Hóa Đơn";
            this.butInHoaDon.Text = "In Hóa Đơn";
            this.butInHoaDon.UseVisualStyleBackColor = true;
            this.butInHoaDon.Click += new System.EventHandler(this.butInHoaDon_Click);
            // 
            // butExit
            // 
            this.butExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.butExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.butExit.IconColor = System.Drawing.Color.White;
            this.butExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butExit.Location = new System.Drawing.Point(0, 634);
            this.butExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(200, 49);
            this.butExit.TabIndex = 7;
            this.butExit.Tag = "Exit";
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.panelMenu.Controls.Add(this.panel5ButEnd);
            this.panelMenu.Controls.Add(this.butExit);
            this.panelMenu.Controls.Add(this.butQuanLi);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 683);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Resize += new System.EventHandler(this.Form1_Resize);
            // 
            // panel5ButEnd
            // 
            this.panel5ButEnd.Controls.Add(this.butInHoaDon);
            this.panel5ButEnd.Controls.Add(this.butDatPhong);
            this.panel5ButEnd.Controls.Add(this.butSapXep);
            this.panel5ButEnd.Controls.Add(this.iconButton2);
            this.panel5ButEnd.Controls.Add(this.butKhachHang);
            this.panel5ButEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5ButEnd.Location = new System.Drawing.Point(0, 150);
            this.panel5ButEnd.Name = "panel5ButEnd";
            this.panel5ButEnd.Size = new System.Drawing.Size(200, 332);
            this.panel5ButEnd.TabIndex = 9;
            // 
            // butDatPhong
            // 
            this.butDatPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.butDatPhong.FlatAppearance.BorderSize = 0;
            this.butDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDatPhong.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDatPhong.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.butDatPhong.IconChar = FontAwesome.Sharp.IconChar.Houzz;
            this.butDatPhong.IconColor = System.Drawing.Color.White;
            this.butDatPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDatPhong.Location = new System.Drawing.Point(0, 160);
            this.butDatPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butDatPhong.Name = "butDatPhong";
            this.butDatPhong.Size = new System.Drawing.Size(200, 60);
            this.butDatPhong.TabIndex = 4;
            this.butDatPhong.Tag = "Đặt Phòng";
            this.butDatPhong.Text = "Đặt Phòng";
            this.butDatPhong.UseVisualStyleBackColor = true;
            this.butDatPhong.Click += new System.EventHandler(this.butDatPhong_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 60);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(200, 50);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Tag = "Báo Cáo";
            this.iconButton2.Text = "Báo Cáo";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.butBaoCao_Click);
            // 
            // dropMenuQuanLi
            // 
            this.dropMenuQuanLi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.dropMenuQuanLi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropMenuQuanLi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dropMenuQuanLi.IsMainMenu = false;
            this.dropMenuQuanLi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíTàiKhoảnToolStripMenuItem,
            this.quảnLíPhòngToolStripMenuItem,
            this.quảnLíNgườiDùngToolStripMenuItem,
            this.quảnLíĐồThấtLạcToolStripMenuItem});
            this.dropMenuQuanLi.MenuItemHeight = 25;
            this.dropMenuQuanLi.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dropMenuQuanLi.Name = "dropMenuQuanLi";
            this.dropMenuQuanLi.PrimaryColor = System.Drawing.Color.Empty;
            this.dropMenuQuanLi.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.dropMenuQuanLi.Size = new System.Drawing.Size(243, 116);
            // 
            // quảnLíTàiKhoảnToolStripMenuItem
            // 
            this.quảnLíTàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quảnLíTàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLíTàiKhoảnToolStripMenuItem.Image")));
            this.quảnLíTàiKhoảnToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quảnLíTàiKhoảnToolStripMenuItem.Name = "quảnLíTàiKhoảnToolStripMenuItem";
            this.quảnLíTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.quảnLíTàiKhoảnToolStripMenuItem.Text = "Quản Lí Tài Khoản";
            this.quảnLíTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLíTàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLíPhòngToolStripMenuItem
            // 
            this.quảnLíPhòngToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quảnLíPhòngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLíPhòngToolStripMenuItem.Image")));
            this.quảnLíPhòngToolStripMenuItem.Name = "quảnLíPhòngToolStripMenuItem";
            this.quảnLíPhòngToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.quảnLíPhòngToolStripMenuItem.Text = "Quản Lí Phòng";
            this.quảnLíPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLíPhòngToolStripMenuItem_Click);
            // 
            // quảnLíNgườiDùngToolStripMenuItem
            // 
            this.quảnLíNgườiDùngToolStripMenuItem.Name = "quảnLíNgườiDùngToolStripMenuItem";
            this.quảnLíNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.quảnLíNgườiDùngToolStripMenuItem.Text = "Quản Lí Người Dùng";
            this.quảnLíNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLíNgườiDùngToolStripMenuItem_Click);
            // 
            // quảnLíĐồThấtLạcToolStripMenuItem
            // 
            this.quảnLíĐồThấtLạcToolStripMenuItem.Name = "quảnLíĐồThấtLạcToolStripMenuItem";
            this.quảnLíĐồThấtLạcToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.quảnLíĐồThấtLạcToolStripMenuItem.Text = "Quản Lí đồ Thất Lạc";
            this.quảnLíĐồThấtLạcToolStripMenuItem.Click += new System.EventHandler(this.quảnLíĐồThấtLạcToolStripMenuItem_Click);
            // 
            // dropMenuBaoCao
            // 
            this.dropMenuBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropMenuBaoCao.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dropMenuBaoCao.IsMainMenu = false;
            this.dropMenuBaoCao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoTổngHợpToolStripMenuItem,
            this.báoCáoCôngNợToolStripMenuItem});
            this.dropMenuBaoCao.MenuItemHeight = 25;
            this.dropMenuBaoCao.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dropMenuBaoCao.Name = "dropMenuBaoCao";
            this.dropMenuBaoCao.PrimaryColor = System.Drawing.Color.Empty;
            this.dropMenuBaoCao.Size = new System.Drawing.Size(206, 52);
            // 
            // báoCáoTổngHợpToolStripMenuItem
            // 
            this.báoCáoTổngHợpToolStripMenuItem.Name = "báoCáoTổngHợpToolStripMenuItem";
            this.báoCáoTổngHợpToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.báoCáoTổngHợpToolStripMenuItem.Text = "Báo Cáo Tổng Hợp";
            // 
            // báoCáoCôngNợToolStripMenuItem
            // 
            this.báoCáoCôngNợToolStripMenuItem.Name = "báoCáoCôngNợToolStripMenuItem";
            this.báoCáoCôngNợToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.báoCáoCôngNợToolStripMenuItem.Text = "Báo Cáo Công Nợ";
            // 
            // dropMenuUser
            // 
            this.dropMenuUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropMenuUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dropMenuUser.IsMainMenu = false;
            this.dropMenuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.dropMenuUser.MenuItemHeight = 25;
            this.dropMenuUser.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dropMenuUser.Name = "dropMenuUser";
            this.dropMenuUser.PrimaryColor = System.Drawing.Color.Empty;
            this.dropMenuUser.Size = new System.Drawing.Size(207, 76);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // _mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1188, 683);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "_mainForm";
            this.Text = "_mainForm";
            this.Load += new System.EventHandler(this._mainForm_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel5ButEnd.ResumeLayout(false);
            this.dropMenuQuanLi.ResumeLayout(false);
            this.dropMenuBaoCao.ResumeLayout(false);
            this.dropMenuUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton butQuanLi;
        private FontAwesome.Sharp.IconButton butKhachHang;
        private FontAwesome.Sharp.IconButton butSapXep;
        private FontAwesome.Sharp.IconButton butInHoaDon;
        private FontAwesome.Sharp.IconButton butExit;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private CustomControls.RJControls.RJDropdownMenu dropMenuQuanLi;
        private System.Windows.Forms.ToolStripMenuItem quảnLíTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíPhòngToolStripMenuItem;
        private CustomControls.RJControls.RJDropdownMenu dropMenuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTổngHợpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoCôngNợToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuPictureBox pictureUser;
        private CustomControls.RJControls.RJDropdownMenu dropMenuUser;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíĐồThấtLạcToolStripMenuItem;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel5ButEnd;
        private FontAwesome.Sharp.IconButton butDatPhong;
    }
}