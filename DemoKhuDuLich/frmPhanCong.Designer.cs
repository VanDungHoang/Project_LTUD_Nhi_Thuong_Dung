namespace DemoKhuDuLich
{
    partial class frmPhanCong
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
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.lvwDangSachPhanCong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtKhuVucLamViec = new System.Windows.Forms.TextBox();
            this.txtIDNhanVien = new System.Windows.Forms.TextBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtIDPhanCong = new System.Windows.Forms.TextBox();
            this.lblIDPhanCong = new System.Windows.Forms.Label();
            this.lblMa_NV = new System.Windows.Forms.Label();
            this.lblNhiemVu = new System.Windows.Forms.Label();
            this.lblDanhSachKhachHang = new System.Windows.Forms.Label();
            this.txtNhiemVuPC = new System.Windows.Forms.TextBox();
            this.txtTimeWork1 = new System.Windows.Forms.TextBox();
            this.txtTimeWork2 = new System.Windows.Forms.TextBox();
            this.lbTime2 = new System.Windows.Forms.Label();
            this.lbTime1 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.radNu);
            this.grbGioiTinh.Controls.Add(this.radNam);
            this.grbGioiTinh.Location = new System.Drawing.Point(588, 147);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Size = new System.Drawing.Size(200, 51);
            this.grbGioiTinh.TabIndex = 27;
            this.grbGioiTinh.TabStop = false;
            this.grbGioiTinh.Text = "Giới Tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(149, 21);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(86, 21);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // lvwDangSachPhanCong
            // 
            this.lvwDangSachPhanCong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader8});
            this.lvwDangSachPhanCong.GridLines = true;
            this.lvwDangSachPhanCong.HideSelection = false;
            this.lvwDangSachPhanCong.Location = new System.Drawing.Point(-5, 297);
            this.lvwDangSachPhanCong.Name = "lvwDangSachPhanCong";
            this.lvwDangSachPhanCong.Size = new System.Drawing.Size(893, 138);
            this.lvwDangSachPhanCong.TabIndex = 33;
            this.lvwDangSachPhanCong.UseCompatibleStateImageBehavior = false;
            this.lvwDangSachPhanCong.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID nhiệm vụ";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã NV";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên NV";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SĐT";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên nhiệm vụ";
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time in";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 6;
            this.columnHeader8.Text = "Time out";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(588, 213);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 34);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(474, 213);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 34);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(252, 213);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 34);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(130, 213);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 34);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(161, 113);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(206, 22);
            this.txtHoTenNV.TabIndex = 22;
            // 
            // txtKhuVucLamViec
            // 
            this.txtKhuVucLamViec.Location = new System.Drawing.Point(551, 59);
            this.txtKhuVucLamViec.Name = "txtKhuVucLamViec";
            this.txtKhuVucLamViec.Size = new System.Drawing.Size(224, 22);
            this.txtKhuVucLamViec.TabIndex = 26;
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.Location = new System.Drawing.Point(161, 62);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.Size = new System.Drawing.Size(126, 22);
            this.txtIDNhanVien.TabIndex = 20;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Location = new System.Drawing.Point(426, 62);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(106, 16);
            this.lblKhuVuc.TabIndex = 25;
            this.lblKhuVuc.Text = "Khu vực làm việc";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(56, 119);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(68, 16);
            this.lblHoTen.TabIndex = 21;
            this.lblHoTen.Text = "Họ tên NV";
            // 
            // txtIDPhanCong
            // 
            this.txtIDPhanCong.Location = new System.Drawing.Point(161, 16);
            this.txtIDPhanCong.Name = "txtIDPhanCong";
            this.txtIDPhanCong.Size = new System.Drawing.Size(126, 22);
            this.txtIDPhanCong.TabIndex = 18;
            // 
            // lblIDPhanCong
            // 
            this.lblIDPhanCong.AutoSize = true;
            this.lblIDPhanCong.Location = new System.Drawing.Point(56, 21);
            this.lblIDPhanCong.Name = "lblIDPhanCong";
            this.lblIDPhanCong.Size = new System.Drawing.Size(87, 16);
            this.lblIDPhanCong.TabIndex = 17;
            this.lblIDPhanCong.Text = "ID Phân công";
            // 
            // lblMa_NV
            // 
            this.lblMa_NV.AutoSize = true;
            this.lblMa_NV.Location = new System.Drawing.Point(56, 65);
            this.lblMa_NV.Name = "lblMa_NV";
            this.lblMa_NV.Size = new System.Drawing.Size(86, 16);
            this.lblMa_NV.TabIndex = 19;
            this.lblMa_NV.Text = "Mã nhân viên";
            // 
            // lblNhiemVu
            // 
            this.lblNhiemVu.AutoSize = true;
            this.lblNhiemVu.Location = new System.Drawing.Point(429, 21);
            this.lblNhiemVu.Name = "lblNhiemVu";
            this.lblNhiemVu.Size = new System.Drawing.Size(63, 16);
            this.lblNhiemVu.TabIndex = 23;
            this.lblNhiemVu.Text = "Nhiệm vụ";
            // 
            // lblDanhSachKhachHang
            // 
            this.lblDanhSachKhachHang.AutoSize = true;
            this.lblDanhSachKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachKhachHang.Location = new System.Drawing.Point(246, 250);
            this.lblDanhSachKhachHang.Name = "lblDanhSachKhachHang";
            this.lblDanhSachKhachHang.Size = new System.Drawing.Size(310, 32);
            this.lblDanhSachKhachHang.TabIndex = 32;
            this.lblDanhSachKhachHang.Text = "Danh sách khách hàng ";
            // 
            // txtNhiemVuPC
            // 
            this.txtNhiemVuPC.Location = new System.Drawing.Point(551, 16);
            this.txtNhiemVuPC.Name = "txtNhiemVuPC";
            this.txtNhiemVuPC.Size = new System.Drawing.Size(224, 22);
            this.txtNhiemVuPC.TabIndex = 24;
            // 
            // txtTimeWork1
            // 
            this.txtTimeWork1.Location = new System.Drawing.Point(455, 116);
            this.txtTimeWork1.Name = "txtTimeWork1";
            this.txtTimeWork1.Size = new System.Drawing.Size(135, 22);
            this.txtTimeWork1.TabIndex = 34;
            // 
            // txtTimeWork2
            // 
            this.txtTimeWork2.Location = new System.Drawing.Point(639, 114);
            this.txtTimeWork2.Name = "txtTimeWork2";
            this.txtTimeWork2.Size = new System.Drawing.Size(149, 22);
            this.txtTimeWork2.TabIndex = 35;
            // 
            // lbTime2
            // 
            this.lbTime2.AutoSize = true;
            this.lbTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTime2.Location = new System.Drawing.Point(596, 116);
            this.lbTime2.Name = "lbTime2";
            this.lbTime2.Size = new System.Drawing.Size(36, 20);
            this.lbTime2.TabIndex = 36;
            this.lbTime2.Text = "To:";
            // 
            // lbTime1
            // 
            this.lbTime1.AutoSize = true;
            this.lbTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTime1.Location = new System.Drawing.Point(396, 119);
            this.lbTime1.Name = "lbTime1";
            this.lbTime1.Size = new System.Drawing.Size(53, 18);
            this.lbTime1.TabIndex = 37;
            this.lbTime1.Text = "From:";
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 7;
            this.columnHeader7.Text = "Khu vực";
            this.columnHeader7.Width = 80;
            // 
            // frmPhanCong
            // 
            this.AcceptButton = this.btnSua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.lbTime1);
            this.Controls.Add(this.lbTime2);
            this.Controls.Add(this.txtTimeWork2);
            this.Controls.Add(this.txtTimeWork1);
            this.Controls.Add(this.grbGioiTinh);
            this.Controls.Add(this.lvwDangSachPhanCong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHoTenNV);
            this.Controls.Add(this.txtKhuVucLamViec);
            this.Controls.Add(this.txtIDNhanVien);
            this.Controls.Add(this.txtNhiemVuPC);
            this.Controls.Add(this.lblKhuVuc);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtIDPhanCong);
            this.Controls.Add(this.lblIDPhanCong);
            this.Controls.Add(this.lblMa_NV);
            this.Controls.Add(this.lblNhiemVu);
            this.Controls.Add(this.lblDanhSachKhachHang);
            this.Name = "frmPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công";
            this.Load += new System.EventHandler(this.FrmPhanCong_Load);
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGioiTinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.ListView lvwDangSachPhanCong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.TextBox txtKhuVucLamViec;
        private System.Windows.Forms.TextBox txtIDNhanVien;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtIDPhanCong;
        private System.Windows.Forms.Label lblIDPhanCong;
        private System.Windows.Forms.Label lblMa_NV;
        private System.Windows.Forms.Label lblNhiemVu;
        private System.Windows.Forms.Label lblDanhSachKhachHang;
        private System.Windows.Forms.TextBox txtNhiemVuPC;
        private System.Windows.Forms.TextBox txtTimeWork1;
        private System.Windows.Forms.TextBox txtTimeWork2;
        private System.Windows.Forms.Label lbTime2;
        private System.Windows.Forms.Label lbTime1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}