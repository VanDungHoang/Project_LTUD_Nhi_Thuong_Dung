using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoKhuDuLich
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void lblIDKhachHang_Click(object sender, EventArgs e)
        {

        }
        private void lvDangSachKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dong = lvDangSachHoaDon.SelectedIndices[0];
            txtIDHoaDon.Text = lvDangSachHoaDon.Items[dong].SubItems[0].Text;
            txtTenKhachHang.Text = lvDangSachHoaDon.Items[dong].SubItems[1].Text;
            txtSDT.Text = lvDangSachHoaDon.Items[dong].SubItems[2].Text;
            txtCCCD.Text = lvDangSachHoaDon.Items[dong].SubItems[3].Text;
            txtDiaChi.Text = lvDangSachHoaDon.Items[dong].SubItems[4].Text;
            radNam.Checked = true;

        }

       

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dong = lvDangSachHoaDon.SelectedIndices[0];
            lvDangSachHoaDon.Items[dong].SubItems[0].Text = txtIDHoaDon.Text;
            lvDangSachHoaDon.Items[dong].SubItems[1].Text = txtTenKhachHang.Text;
            lvDangSachHoaDon.Items[dong].SubItems[2].Text = txtSDT.Text;
            lvDangSachHoaDon.Items[dong].SubItems[3].Text = txtCCCD.Text;
            lvDangSachHoaDon.Items[dong].SubItems[4].Text = txtDiaChi.Text;
            lvDangSachHoaDon.Items[dong].SubItems[5].Text = radNam.Checked ? "Nam" : "Nữ";
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show(" Bạn có muốn thoát ", " Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                //this.Close();
            Application.Exit();

            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool invalidInput = false; // checkout input IsNullOrWhiteSpace
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtIDHoaDon.Text);
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtTenKhachHang.Text);
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtCCCD.Text);
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtSDT.Text);
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtDiaChi.Text);
            invalidInput = invalidInput || (!radNam.Checked && !radNu.Checked);

            if (invalidInput)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtIDHoaDon.Text;
                item.SubItems.Add(txtIDHoaDon.Text);
                item.SubItems.Add(txtTenKhachHang.Text);
                item.SubItems.Add(txtCCCD.Text);
                item.SubItems.Add(txtSDT.Text);
                item.SubItems.Add(txtDiaChi.Text);
                item.SubItems.Add(radNam.Checked ? "Nam" : "Nữ");
                lvDangSachHoaDon.Items.Add(item);

                // clean field
                txtIDHoaDon.Clear();
                txtTenKhachHang.Clear();
                txtCCCD.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();

            }
        }

    }
}

