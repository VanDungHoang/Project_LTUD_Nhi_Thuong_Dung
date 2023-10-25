namespace DemoKhuDuLich
{
    partial class frmThongTinTaiKHoan
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
            this.lblIdNhanVien = new System.Windows.Forms.Label();
            this.txtIDNhanVien = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDanhSachTaiKhoanNV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblIdNhanVien
            // 
            this.lblIdNhanVien.AutoSize = true;
            this.lblIdNhanVien.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblIdNhanVien.Location = new System.Drawing.Point(110, 26);
            this.lblIdNhanVien.Name = "lblIdNhanVien";
            this.lblIdNhanVien.Size = new System.Drawing.Size(80, 16);
            this.lblIdNhanVien.TabIndex = 0;
            this.lblIdNhanVien.Text = "ID nhân viên";
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.Location = new System.Drawing.Point(265, 23);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.Size = new System.Drawing.Size(189, 22);
            this.txtIDNhanVien.TabIndex = 1;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTenNhanVien.Location = new System.Drawing.Point(110, 81);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(91, 16);
            this.lblTenNhanVien.TabIndex = 0;
            this.lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(265, 78);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(189, 22);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSua.Location = new System.Drawing.Point(102, 153);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnXoa.Location = new System.Drawing.Point(342, 153);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 36);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnThoat.Location = new System.Drawing.Point(578, 153);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 36);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(202, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách Tài Khoản nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvDanhSachTaiKhoanNV
            // 
            this.lvDanhSachTaiKhoanNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvDanhSachTaiKhoanNV.GridLines = true;
            this.lvDanhSachTaiKhoanNV.HideSelection = false;
            this.lvDanhSachTaiKhoanNV.Location = new System.Drawing.Point(64, 271);
            this.lvDanhSachTaiKhoanNV.Name = "lvDanhSachTaiKhoanNV";
            this.lvDanhSachTaiKhoanNV.Size = new System.Drawing.Size(686, 157);
            this.lvDanhSachTaiKhoanNV.TabIndex = 7;
            this.lvDanhSachTaiKhoanNV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachTaiKhoanNV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phòng Ban";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Nhân Viên";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Sinh";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giới tính";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "MaNQL";
            this.columnHeader7.Width = 79;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Lương";
            this.columnHeader8.Width = 69;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Sdth";
            // 
            // frmThongTinTaiKHoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lvDanhSachTaiKhoanNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.txtIDNhanVien);
            this.Controls.Add(this.lblIdNhanVien);
            this.Name = "frmThongTinTaiKHoan";
            this.Text = "frmThongTinTaiKHoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdNhanVien;
        private System.Windows.Forms.TextBox txtIDNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDanhSachTaiKhoanNV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}