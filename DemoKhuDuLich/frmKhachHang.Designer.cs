using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoKhuDuLich
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
            this.lblDanhSachKhachHang = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtIDKhachHang = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblSDTh = new System.Windows.Forms.Label();
            this.txtSDTh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lvDangSachKhachHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIDKhachHang = new System.Windows.Forms.Label();
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDanhSachKhachHang
            // 
            this.lblDanhSachKhachHang.AutoSize = true;
            this.lblDanhSachKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachKhachHang.Location = new System.Drawing.Point(232, 253);
            this.lblDanhSachKhachHang.Name = "lblDanhSachKhachHang";
            this.lblDanhSachKhachHang.Size = new System.Drawing.Size(310, 32);
            this.lblDanhSachKhachHang.TabIndex = 15;
            this.lblDanhSachKhachHang.Text = "Danh sách khách hàng ";
            this.lblDanhSachKhachHang.Click += new System.EventHandler(this.lblDanhSachKhachHang_Click);
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(430, 19);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(44, 16);
            this.lblCCCD.TabIndex = 6;
            this.lblCCCD.Text = "CCCD";
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.Location = new System.Drawing.Point(194, 19);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.Size = new System.Drawing.Size(126, 22);
            this.txtIDKhachHang.TabIndex = 1;
            this.txtIDKhachHang.TextChanged += new System.EventHandler(this.txtIDKhachHang_TextChanged);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(499, 19);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(134, 22);
            this.txtCCCD.TabIndex = 7;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(84, 67);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(103, 16);
            this.lblTenKhachHang.TabIndex = 2;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            this.lblTenKhachHang.Click += new System.EventHandler(this.lblTenKhachHang_Click);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(430, 58);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ ";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(194, 64);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(126, 22);
            this.txtTenKhachHang.TabIndex = 3;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(499, 58);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(134, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // lblSDTh
            // 
            this.lblSDTh.AutoSize = true;
            this.lblSDTh.Location = new System.Drawing.Point(105, 116);
            this.lblSDTh.Name = "lblSDTh";
            this.lblSDTh.Size = new System.Drawing.Size(34, 16);
            this.lblSDTh.TabIndex = 4;
            this.lblSDTh.Text = "Sdth";
            this.lblSDTh.Click += new System.EventHandler(this.lblSDTh_Click);
            // 
            // txtSDTh
            // 
            this.txtSDTh.Location = new System.Drawing.Point(194, 116);
            this.txtSDTh.Name = "txtSDTh";
            this.txtSDTh.Size = new System.Drawing.Size(126, 22);
            this.txtSDTh.TabIndex = 5;
            this.txtSDTh.TextChanged += new System.EventHandler(this.txtSDTh_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(149, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 34);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(285, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 34);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(411, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 34);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(536, 200);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 34);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lvDangSachKhachHang
            // 
            this.lvDangSachKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvDangSachKhachHang.GridLines = true;
            this.lvDangSachKhachHang.HideSelection = false;
            this.lvDangSachKhachHang.Location = new System.Drawing.Point(43, 300);
            this.lvDangSachKhachHang.Name = "lvDangSachKhachHang";
            this.lvDangSachKhachHang.Size = new System.Drawing.Size(723, 138);
            this.lvDangSachKhachHang.TabIndex = 16;
            this.lvDangSachKhachHang.UseCompatibleStateImageBehavior = false;
            this.lvDangSachKhachHang.View = System.Windows.Forms.View.Details;
            this.lvDangSachKhachHang.SelectedIndexChanged += new System.EventHandler(this.lvDangSachKhachHang_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 29;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên khách hàng";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sdth";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CCCD";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa Chỉ";
            // 
            // lblIDKhachHang
            // 
            this.lblIDKhachHang.AutoSize = true;
            this.lblIDKhachHang.Location = new System.Drawing.Point(84, 19);
            this.lblIDKhachHang.Name = "lblIDKhachHang";
            this.lblIDKhachHang.Size = new System.Drawing.Size(92, 16);
            this.lblIDKhachHang.TabIndex = 0;
            this.lblIDKhachHang.Text = "ID khách hàng";
            this.lblIDKhachHang.Click += new System.EventHandler(this.lblIDKhachHang_Click);
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.radNu);
            this.grbGioiTinh.Controls.Add(this.radNam);
            this.grbGioiTinh.Location = new System.Drawing.Point(433, 104);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Size = new System.Drawing.Size(200, 63);
            this.grbGioiTinh.TabIndex = 10;
            this.grbGioiTinh.TabStop = false;
            this.grbGioiTinh.Text = "Giới Tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(122, 32);
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
            this.radNam.Location = new System.Drawing.Point(30, 32);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giới Tính";
            this.columnHeader6.Width = 67;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grbGioiTinh);
            this.Controls.Add(this.lvDangSachKhachHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSDTh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblSDTh);
            this.Controls.Add(this.txtIDKhachHang);
            this.Controls.Add(this.lblIDKhachHang);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblDanhSachKhachHang);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Thông Tin khách hàng")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                this.Hide();

                frmKhachHang ttkh = new frmKhachHang();
                ttkh.ShowDialog();
                this.Show();
            }
        }

        private void lblIDKhachHang_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = txtIDKhachHang.Text;
            item.SubItems.Add(txtIDKhachHang.Text);
            item.SubItems.Add(txtSDTh.Text);
            item.SubItems.Add(txtCCCD.Text);
            item.SubItems.Add(txtDiaChi.Text);
            item.SubItems.Add(radNam.Checked ? "Nam" : "Nữ");
            lvDangSachKhachHang.Items.Add(item);
        }

        private void txtSDTh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblTenKhachHang_Click(object sender, EventArgs e)
        {
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblSDTh_Click(object sender, EventArgs e)
        {
            
        }

        private void txtIDKhachHang_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label lblDanhSachKhachHang;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtIDKhachHang;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSDTh;
        private System.Windows.Forms.TextBox txtSDTh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvDangSachKhachHang;
        private System.Windows.Forms.Label lblIDKhachHang;
        private System.Windows.Forms.GroupBox grbGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}