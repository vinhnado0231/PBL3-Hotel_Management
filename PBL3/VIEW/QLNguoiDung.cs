using PBL3.BLL;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTOVIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PBL3
{
    public partial class QLNguoiDung : Form
    {
        public QLNguoiDung()
        {
            InitializeComponent();
            setCBB();
            showNV();
        }
        public void setCBB()
        {
            cbbGender.Items.Add("Nam");
            cbbGender.Items.Add("Nữ");
            string[] item1 = new string[] { "Mã nhân viên", "Tên nhân viên","Tên tài khoản" ,"Chức vụ" };
            cbbSort.Items.AddRange(item1);
            cbbSort.SelectedIndex = 0;
            cbbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPosition.Items.AddRange(QLChucVu_BLL.Instance.getCbbChucVu().ToArray());
        }
        public void showNV()
        {
            dataGridView.DataSource= QLNhanVien_BLL.Instance.getAllNhanVien(txtSearch.Text,cbbSort.Text);
            DataGridViewColumn Stt = new DataGridViewColumn() { Name = "stt", HeaderText = "STT", CellTemplate = new DataGridViewTextBoxCell() };
            dataGridView.Columns["MatKhau"].Visible = false;
            foreach (DataGridViewBand band in dataGridView.Columns)
            {
                band.ReadOnly = true;
            }
            dtNgayVaoLam.Format = DateTimePickerFormat.Short;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showNV();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtMaNV.Enabled = true;
            txtCMND.Text = "";
            txtName.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtSearch.Text = "";
            txtIdTaiKhoan.Text = "";
            txtTaiKhoan.Text = "";
            dtNgayVaoLam.CustomFormat = "";
            dtNgayVaoLam.Format = DateTimePickerFormat.Custom;
            cbbGender.ResetText();
            cbbSort.SelectedIndex = 0;
            cbbPosition.SelectedIndex = -1;
            txtMatKhau.Text = "";
            showNV();
        }

        private void cbbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            showNV();
        }
        private void addOrUpdate()
        {
            NhanVien nhanVien = new NhanVien();
            TaiKhoan taiKhoan = new TaiKhoan();
            nhanVien.Ten = txtName.Text;
            nhanVien.CMND = txtCMND.Text;
            nhanVien.IdNhanVien = txtMaNV.Text;
            nhanVien.SDT = txtSDT.Text;
            nhanVien.DiaChi = txtDiaChi.Text;
            nhanVien.NgayVaoLam = dtNgayVaoLam.Value;
            if (cbbGender.SelectedIndex == 0)
            {
                nhanVien.GioiTinh = true;
            }
            else
            {
                nhanVien.GioiTinh = false;
            }
            nhanVien.IdChucVu = ((CBBItem)cbbPosition.SelectedItem).Value;            
            nhanVien.ChucVu = QLChucVu_BLL.Instance.getChucVuById(((CBBItem)cbbPosition.SelectedItem).Value);
            nhanVien.IdTaiKhoan = txtIdTaiKhoan.Text;
            taiKhoan.IdTaiKhoan = txtIdTaiKhoan.Text;
            taiKhoan.TenDangNhap = txtTaiKhoan.Text;
            taiKhoan.MatKhau = txtMatKhau.Text;
            taiKhoan.TrangThai = false;
            nhanVien.TaiKhoan = taiKhoan;
            QLNhanVien_BLL.Instance.addOrUpdate(nhanVien);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            QLKS db = new QLKS();
            addOrUpdate();
            showNV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addOrUpdate();
            showNV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow i in dataGridView.SelectedRows)
                {
                    DialogResult confirmResult = MessageBox.Show("Bạn có chắc muốn xoá nhân viên mã số " + i.Cells["IdNhanVien"].Value.ToString() + " không?", "Cảnh báo", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        QLNhanVien_BLL.Instance.delete(i.Cells["IdNhanVien"].Value.ToString());
                    }
                    else
                    {

                    }
                }
            }
            showNV();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showInfoNV(dataGridView.SelectedRows[0].Cells["IdNhanVien"].Value.ToString());
        }

        private void showInfoNV(string id)
        {
            NhanVien nhanVien = QLNhanVien_BLL.Instance.findNhanVienById(id);
            if (nhanVien != null)
            {
                txtMaNV.Text = nhanVien.IdNhanVien;
                txtMaNV.Enabled = false;
                txtCMND.Text = nhanVien.CMND;
                txtName.Text = nhanVien.Ten;
                txtIdTaiKhoan.Text = nhanVien.IdTaiKhoan;
                txtTaiKhoan.Text = nhanVien.TaiKhoan.TenDangNhap;
                txtMatKhau.Text = nhanVien.TaiKhoan.MatKhau;
                txtDiaChi.Text = nhanVien.DiaChi;
                txtSDT.Text = nhanVien.SDT;
                dtNgayVaoLam.Value = (DateTime)nhanVien.NgayVaoLam;
                if (nhanVien.GioiTinh)
                {
                    cbbGender.SelectedIndex = 0;
                }
                else
                {
                    cbbGender.SelectedIndex = 1;
                }
                foreach (CBBItem item in cbbPosition.Items)
                {
                    if (nhanVien.IdChucVu == item.Value)
                    {
                        cbbPosition.SelectedItem = item;
                        break;
                    }
                }
            }
        }
    }
}
