using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Windows.Forms;

namespace PBL3
{
    public partial class formDSKH : Form
    {
        public formDSKH()
        {
            InitializeComponent();
            showKH();
            showCBB();
        }
        private void showCBB()
        {
            cbbGender.Items.Add("Nam");
            cbbGender.Items.Add("Nữ");
            string[] item = new string[] { "Mã khách hàng", "Tên khách hàng", "Quốc tịch" };
            cbbSort.Items.AddRange(item);
            cbbSort.SelectedIndex = 0;
            cbbSort.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void showKH()
        {
            dataGridView.DataSource = QLKhachHang_BLL.Instance.getAllKhachHang(txtSearch.Text, cbbSort.Text);
            DataGridViewColumn Stt = new DataGridViewColumn() { Name = "stt", HeaderText = "STT", CellTemplate = new DataGridViewTextBoxCell() };

            foreach (DataGridViewBand band in dataGridView.Columns)
            {
                band.ReadOnly = true;
            }
            dtNgaySinh.Format = DateTimePickerFormat.Short;
            int stt = 1;
            if (!dataGridView.Columns.Contains("stt"))
            {
                dataGridView.Columns.Insert(0, Stt);
            }
            foreach (DataGridViewRow i in dataGridView.Rows)
            {
                i.Cells["Stt"].Value = stt++;
            }
        }

        private void showInfoKH(string id)
        {
            KhachHang khachHang = QLKhachHang_BLL.Instance.findKhachHangById(id);
            if (khachHang != null)
            {
                txtMaKH.Text = khachHang.IdKhachHang;
                txtMaKH.Enabled = false;
                txtCMND.Text = khachHang.CMND;
                txtName.Text = khachHang.Ten;
                txtNote.Text = khachHang.GhiChu;
                txtQuocTich.Text = khachHang.QuocTich;
                txtSDT.Text = khachHang.SDT;
                dtNgaySinh.Value = khachHang.NgaySinh;
                if (khachHang.GioiTinh)
                {
                    cbbGender.SelectedIndex = 0;
                }
                else
                {
                    cbbGender.SelectedIndex = 1;
                }
            }
        }

        private void addOrUpdate(string id)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.IdKhachHang = txtMaKH.Text;
            khachHang.CMND = txtCMND.Text;
            khachHang.Ten = txtName.Text;
            khachHang.GhiChu = txtNote.Text;
            khachHang.QuocTich = txtQuocTich.Text;
            khachHang.SDT = txtSDT.Text;
            khachHang.NgaySinh = dtNgaySinh.Value;
            if (cbbGender.SelectedIndex == 0)
            {
                khachHang.GioiTinh = true;
            }
            else
            {
                khachHang.GioiTinh = false;
            }
            QLKhachHang_BLL.Instance.addOrUpdate(khachHang);
            showKH();
        }


        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showInfoKH(dataGridView.SelectedRows[0].Cells["IdKhachHang"].Value.ToString());
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (QLKhachHang_BLL.Instance.findKhachHangById(txtMaKH.Text) == null)
            {
                try
                {
                    addOrUpdate(txtMaKH.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                addOrUpdate(txtMaKH.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn cần phải nhập đầy đủ thông tin");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView.SelectedRows)
                {
                    DialogResult confirmResult = MessageBox.Show("Bạn có chắc muốn xoá khách hàng mã số " + i.Cells["IdKhachHang"].Value.ToString() + " không?", "Cảnh báo", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        QLKhachHang_BLL.Instance.delete(i.Cells["IdKhachHang"].Value.ToString());
                    }
                    else
                    {

                    }
                }
            }
            showKH();
        }

        private void cbbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            showKH();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showKH();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtMaKH.Enabled = true;
            txtCMND.Text = "";
            txtName.Text = "";
            txtQuocTich.Text = "";
            txtSDT.Text = "";
            txtSearch.Text = "";
            txtNote.Text = "";
            dtNgaySinh.CustomFormat = " ";
            dtNgaySinh.Format = DateTimePickerFormat.Custom;
            cbbGender.ResetText();
            cbbSort.SelectedIndex = 0;
            showKH();
        }
    }
}
