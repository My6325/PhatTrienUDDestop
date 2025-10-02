using System.Windows.Forms;

namespace BaiTapNhapTTSV
{
    partial class frmTTSV
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHoTenLot = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.txtHoTenLot = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.checkedListBoxMonHoc = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStripMonHoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtbMSSV = new System.Windows.Forms.MaskedTextBox();
            this.mtbCMND = new System.Windows.Forms.MaskedTextBox();
            this.mtbSDT = new System.Windows.Forms.MaskedTextBox();
            this.grboxdanhsachSV = new System.Windows.Forms.GroupBox();
            this.listViewDSSV = new System.Windows.Forms.ListView();
            this.clMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHoTenLot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripSinhVien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bạnMuốnĐọcFileTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMonHoc.SuspendLayout();
            this.grboxdanhsachSV.SuspendLayout();
            this.contextMenuStripSinhVien.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(23, 15);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(51, 16);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV :";
            // 
            // lblHoTenLot
            // 
            this.lblHoTenLot.AutoSize = true;
            this.lblHoTenLot.Location = new System.Drawing.Point(24, 55);
            this.lblHoTenLot.Name = "lblHoTenLot";
            this.lblHoTenLot.Size = new System.Drawing.Size(87, 16);
            this.lblHoTenLot.TabIndex = 1;
            this.lblHoTenLot.Text = "Họ và tên lót :";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(23, 92);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(75, 16);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày Sinh :";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(23, 132);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(73, 16);
            this.lblCMND.TabIndex = 3;
            this.lblCMND.Text = "Số CMND :";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(23, 172);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(98, 16);
            this.lblDC.TabIndex = 4;
            this.lblDC.Text = "Địa chỉ liên lạc :";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(23, 242);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(115, 16);
            this.lblMonHoc.TabIndex = 5;
            this.lblMonHoc.Text = "Môn học đăng ký :";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(432, 21);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(66, 16);
            this.lblGT.TabIndex = 6;
            this.lblGT.Text = "Giới Tính :";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(432, 62);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(37, 16);
            this.lblTen.TabIndex = 7;
            this.lblTen.Text = "Tên :";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(432, 98);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(36, 16);
            this.lblLop.TabIndex = 8;
            this.lblLop.Text = "Lớp :";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(432, 138);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(51, 16);
            this.lblSDT.TabIndex = 9;
            this.lblSDT.Text = "Số ĐT :";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(533, 17);
            this.rdNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 1;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(637, 17);
            this.rdNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 11;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // txtHoTenLot
            // 
            this.txtHoTenLot.Location = new System.Drawing.Point(148, 49);
            this.txtHoTenLot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenLot.Name = "txtHoTenLot";
            this.txtHoTenLot.Size = new System.Drawing.Size(247, 22);
            this.txtHoTenLot.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(533, 55);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(239, 22);
            this.txtTen.TabIndex = 3;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "CTK47A",
            "CTK47B",
            "CTK47C"});
            this.cbLop.Location = new System.Drawing.Point(533, 90);
            this.cbLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(239, 24);
            this.cbLop.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(148, 172);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(623, 22);
            this.txtDiaChi.TabIndex = 8;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(148, 86);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(247, 22);
            this.dtNgaySinh.TabIndex = 4;
            this.dtNgaySinh.Value = new System.DateTime(2025, 9, 26, 20, 18, 14, 0);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(283, 315);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(92, 36);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(428, 315);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 36);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(577, 315);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(92, 36);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(721, 315);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 36);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // checkedListBoxMonHoc
            // 
            this.checkedListBoxMonHoc.CheckOnClick = true;
            this.checkedListBoxMonHoc.ColumnWidth = 200;
            this.checkedListBoxMonHoc.ContextMenuStrip = this.contextMenuStripMonHoc;
            this.checkedListBoxMonHoc.FormattingEnabled = true;
            this.checkedListBoxMonHoc.Location = new System.Drawing.Point(149, 213);
            this.checkedListBoxMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxMonHoc.MultiColumn = true;
            this.checkedListBoxMonHoc.Name = "checkedListBoxMonHoc";
            this.checkedListBoxMonHoc.Size = new System.Drawing.Size(955, 72);
            this.checkedListBoxMonHoc.TabIndex = 9;
            this.checkedListBoxMonHoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxMonHoc_MouseDown);
            // 
            // contextMenuStripMonHoc
            // 
            this.contextMenuStripMonHoc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.thêmToolStripMenuItem});
            this.contextMenuStripMonHoc.Name = "contextMenuStripMonHoc";
            this.contextMenuStripMonHoc.Size = new System.Drawing.Size(116, 52);
            this.contextMenuStripMonHoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxMonHoc_MouseDown);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // mtbMSSV
            // 
            this.mtbMSSV.Location = new System.Drawing.Point(148, 9);
            this.mtbMSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbMSSV.Mask = "0000000";
            this.mtbMSSV.Name = "mtbMSSV";
            this.mtbMSSV.Size = new System.Drawing.Size(247, 22);
            this.mtbMSSV.TabIndex = 0;
            // 
            // mtbCMND
            // 
            this.mtbCMND.Location = new System.Drawing.Point(148, 126);
            this.mtbCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbCMND.Mask = "000000000";
            this.mtbCMND.Name = "mtbCMND";
            this.mtbCMND.Size = new System.Drawing.Size(247, 22);
            this.mtbCMND.TabIndex = 6;
            // 
            // mtbSDT
            // 
            this.mtbSDT.Location = new System.Drawing.Point(533, 132);
            this.mtbSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbSDT.Mask = "0000.000.000";
            this.mtbSDT.Name = "mtbSDT";
            this.mtbSDT.Size = new System.Drawing.Size(239, 22);
            this.mtbSDT.TabIndex = 7;
            // 
            // grboxdanhsachSV
            // 
            this.grboxdanhsachSV.Controls.Add(this.listViewDSSV);
            this.grboxdanhsachSV.Location = new System.Drawing.Point(12, 355);
            this.grboxdanhsachSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grboxdanhsachSV.Name = "grboxdanhsachSV";
            this.grboxdanhsachSV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grboxdanhsachSV.Size = new System.Drawing.Size(1807, 265);
            this.grboxdanhsachSV.TabIndex = 27;
            this.grboxdanhsachSV.TabStop = false;
            this.grboxdanhsachSV.Text = "Danh sách sinh viên";
            // 
            // listViewDSSV
            // 
            this.listViewDSSV.CheckBoxes = true;
            this.listViewDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMSSV,
            this.clHoTenLot,
            this.clTen,
            this.clNgaySinh,
            this.clGT,
            this.clLop,
            this.clCMND,
            this.clSDT,
            this.clDiaChi,
            this.clMonHoc});
            this.listViewDSSV.ContextMenuStrip = this.contextMenuStripSinhVien;
            this.listViewDSSV.FullRowSelect = true;
            this.listViewDSSV.GridLines = true;
            this.listViewDSSV.HideSelection = false;
            this.listViewDSSV.Location = new System.Drawing.Point(0, 20);
            this.listViewDSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewDSSV.Name = "listViewDSSV";
            this.listViewDSSV.Size = new System.Drawing.Size(1801, 232);
            this.listViewDSSV.TabIndex = 0;
            this.listViewDSSV.UseCompatibleStateImageBehavior = false;
            this.listViewDSSV.View = System.Windows.Forms.View.Details;
            this.listViewDSSV.SelectedIndexChanged += new System.EventHandler(this.listViewDSSV_SelectedIndexChanged);
            this.listViewDSSV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewDSSV_MouseDown);
            // 
            // clMSSV
            // 
            this.clMSSV.Text = "MSSV";
            this.clMSSV.Width = 73;
            // 
            // clHoTenLot
            // 
            this.clHoTenLot.Text = "Họ và tên lót";
            this.clHoTenLot.Width = 137;
            // 
            // clTen
            // 
            this.clTen.Text = "Tên";
            this.clTen.Width = 72;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.Text = "Ngày sinh";
            this.clNgaySinh.Width = 87;
            // 
            // clGT
            // 
            this.clGT.Text = "Giới tính";
            this.clGT.Width = 70;
            // 
            // clLop
            // 
            this.clLop.Text = "Lớp";
            this.clLop.Width = 70;
            // 
            // clCMND
            // 
            this.clCMND.Text = "Số CMND";
            this.clCMND.Width = 102;
            // 
            // clSDT
            // 
            this.clSDT.Text = "Số điện thoại";
            this.clSDT.Width = 105;
            // 
            // clDiaChi
            // 
            this.clDiaChi.Text = "Địa chỉ liên lạc";
            this.clDiaChi.Width = 130;
            // 
            // clMonHoc
            // 
            this.clMonHoc.Text = "Môn học đã đăng kí";
            this.clMonHoc.Width = 563;
            // 
            // contextMenuStripSinhVien
            // 
            this.contextMenuStripSinhVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSinhVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaSinhViênToolStripMenuItem});
            this.contextMenuStripSinhVien.Name = "contextMenuStripSinhVien";
            this.contextMenuStripSinhVien.Size = new System.Drawing.Size(166, 28);
            this.contextMenuStripSinhVien.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewDSSV_MouseDown);
            // 
            // xóaSinhViênToolStripMenuItem
            // 
            this.xóaSinhViênToolStripMenuItem.Name = "xóaSinhViênToolStripMenuItem";
            this.xóaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.xóaSinhViênToolStripMenuItem.Text = "Xóa sinh viên";
            this.xóaSinhViênToolStripMenuItem.Click += new System.EventHandler(this.xóaSinhViênToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bạnMuốnĐọcFileTừToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1831, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bạnMuốnĐọcFileTừToolStripMenuItem
            // 
            this.bạnMuốnĐọcFileTừToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem,
            this.jsonToolStripMenuItem,
            this.xmlToolStripMenuItem});
            this.bạnMuốnĐọcFileTừToolStripMenuItem.Name = "bạnMuốnĐọcFileTừToolStripMenuItem";
            this.bạnMuốnĐọcFileTừToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.bạnMuốnĐọcFileTừToolStripMenuItem.Text = "Bạn muốn đọc file từ";
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.txtToolStripMenuItem.Text = "txt";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.jsonToolStripMenuItem.Text = "json";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xmlToolStripMenuItem.Text = "xml";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.xmlToolStripMenuItem_Click);
            // 
            // frmTTSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1831, 619);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grboxdanhsachSV);
            this.Controls.Add(this.mtbSDT);
            this.Controls.Add(this.mtbCMND);
            this.Controls.Add(this.mtbMSSV);
            this.Controls.Add(this.checkedListBoxMonHoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoTenLot);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTenLot);
            this.Controls.Add(this.lblMSSV);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTTSV";
            this.Text = "Nhập thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmTTSV_Load);
            this.contextMenuStripMonHoc.ResumeLayout(false);
            this.grboxdanhsachSV.ResumeLayout(false);
            this.contextMenuStripSinhVien.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHoTenLot;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtHoTenLot;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckedListBox checkedListBoxMonHoc;
        private System.Windows.Forms.MaskedTextBox mtbMSSV;
        private System.Windows.Forms.MaskedTextBox mtbCMND;
        private System.Windows.Forms.MaskedTextBox mtbSDT;
        private System.Windows.Forms.GroupBox grboxdanhsachSV;
        private System.Windows.Forms.ListView listViewDSSV;
        private System.Windows.Forms.ColumnHeader clMSSV;
        private System.Windows.Forms.ColumnHeader clHoTenLot;
        private System.Windows.Forms.ColumnHeader clTen;
        private System.Windows.Forms.ColumnHeader clNgaySinh;
        private System.Windows.Forms.ColumnHeader clLop;
        private System.Windows.Forms.ColumnHeader clCMND;
        private System.Windows.Forms.ColumnHeader clSDT;
        private System.Windows.Forms.ColumnHeader clDiaChi;
        private System.Windows.Forms.ColumnHeader clGT;
        private System.Windows.Forms.ColumnHeader clMonHoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMonHoc;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private ContextMenuStrip contextMenuStripSinhVien;
        private ToolStripMenuItem xóaSinhViênToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bạnMuốnĐọcFileTừToolStripMenuItem;
        private ToolStripMenuItem txtToolStripMenuItem;
        private ToolStripMenuItem jsonToolStripMenuItem;
        private ToolStripMenuItem xmlToolStripMenuItem;
    }
}

