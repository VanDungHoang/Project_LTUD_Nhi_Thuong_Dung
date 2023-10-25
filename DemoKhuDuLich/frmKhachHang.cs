using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoKhuDuLich
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show(" Bạn có muốn thoát ", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void lblDanhSachKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void lvDangSachKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dong = lvDangSachKhachHang.SelectedIndices[0];
            txtIDKhachHang.Text = lvDangSachKhachHang.Items[dong].SubItems[0].Text;
            txtTenKhachHang.Text = lvDangSachKhachHang.Items[dong].SubItems[1].Text;
            txtSDTh.Text = lvDangSachKhachHang.Items[dong].SubItems[2].Text;
            txtCCCD.Text = lvDangSachKhachHang.Items[dong].SubItems[3].Text;
            txtDiaChi.Text = lvDangSachKhachHang.Items[dong].SubItems[4].Text;
            radNam.Checked = true;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //lvDangSachKhachHang.Items.Remove(lvDangSachKhachHang.SelectedItems[0]);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dong = lvDangSachKhachHang.SelectedIndices[0];
            lvDangSachKhachHang.Items[dong].SubItems[0].Text = txtIDKhachHang.Text;
            lvDangSachKhachHang.Items[dong].SubItems[1].Text = txtTenKhachHang.Text;
            lvDangSachKhachHang.Items[dong].SubItems[2].Text = txtSDTh.Text;
            lvDangSachKhachHang.Items[dong].SubItems[3].Text = txtCCCD.Text;
            lvDangSachKhachHang.Items[dong].SubItems[4].Text = txtDiaChi.Text;
            lvDangSachKhachHang.Items[dong].SubItems[5].Text = radNam.Checked ? "Nam" : "Nữ";
        }
    }
}
