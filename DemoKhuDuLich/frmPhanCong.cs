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
    public partial class frmPhanCong : Form
    {
        public frmPhanCong()
        {
            InitializeComponent();
        }

        private void FrmPhanCong_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool invalidInput = false; // checkout input IsNullOrWhiteSpace
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtIDPhanCong.Text);
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtIDNhanVien.Text);
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtHoTenNV.Text);
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtNhiemVuPC.Text);
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtKhuVucLamViec.Text);
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtTimeWork1.Text);
            invalidInput = invalidInput || string.IsNullOrWhiteSpace(txtTimeWork2.Text);
            invalidInput = invalidInput || (!radNam.Checked && !radNu.Checked);

            if (invalidInput)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtIDPhanCong.Text;
                item.SubItems.Add(txtIDNhanVien.Text);
                item.SubItems.Add(txtHoTenNV.Text);
                item.SubItems.Add(txtNhiemVuPC.Text);
                item.SubItems.Add(txtKhuVucLamViec.Text);
                item.SubItems.Add(txtTimeWork1.Text);
                item.SubItems.Add(txtTimeWork2.Text);
                item.SubItems.Add(radNam.Checked ? "Nam" : "Nữ");
                lvwDangSachPhanCong.Items.Add(item);

                // clean field
                txtIDPhanCong.Clear();
                txtIDNhanVien.Clear();
                txtHoTenNV.Clear();
                txtNhiemVuPC.Clear();
                txtKhuVucLamViec.Clear();
                txtTimeWork1.Clear();
                txtTimeWork2.Clear();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult f = MessageBox.Show("Lưu lại trước khi thoát ? ", " Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                // code lưa lại

                //thoát
                this.Close();
            }
            else
            {
                if (f == DialogResult.No)
                {
                    //thoát
                    this.Close();
                }
            }
                    Application.Exit();
        }
    }
}
