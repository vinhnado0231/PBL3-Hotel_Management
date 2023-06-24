using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTOVIEW;

namespace PBL3.VIEW
{
    public partial class formTraPhong : Form
    {
        QLKS qlks = new QLKS();
        string IdPhong = "1P1";
        public delegate void Mydel();
        public Mydel reload;
        public formTraPhong(string m)
        {
            IdPhong = m;
            InitializeComponent();
            setCbbTenDV();
            txtDonGia.Enabled = false;
            txtMaDichVu.Enabled = false;
        }

        public void setCbbTenDV()
        {
            
            foreach (DichVu i in ThanhToanHoaDon_BLL.Instance.GetAllDichVu())
            {
                cbbTenDV.Items.Add(new CBBItem { Text = i.TenDichVu, Value = i.IdDichVu});
            }
        }

        public void SetSTT()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        public void ShowView()
        {
            dataGridView.DataSource = ThanhToanHoaDon_BLL.Instance.GetThanhToanDVView(IdPhong).ToList();


            HoaDon data = ThanhToanHoaDon_BLL.Instance.GetHoaDonByIdPhong(IdPhong);
            ChiTietThuePhong chiTietThuePhong = ThanhToanHoaDon_BLL.Instance.GetChiTietThuePhongByIdPhong(IdPhong);

            lbMaHoaDon.Text = data.IdHoaDon.ToString();
            lbMaKhachHang.Text = data.IDKhachHang.ToString();
            lbTenKhachHang.Text = data.KhachHang.Ten.ToString();
            lbTenPhong.Text = chiTietThuePhong.Phong.TenPhong;
            lbNhanVien.Text = data.NhanVien.Ten.ToString();
            lbNgayLap.Text = data.NgayHoaDon.ToString();
            lbNgayThue.Text = chiTietThuePhong.NgayCheckIn.ToString();
            lbNgayTra.Text = chiTietThuePhong.NgayCheckOut.ToString();
            lbGiaPhong.Text = chiTietThuePhong.Phong.DonGiaPhong.ToString();

            int TongtienDV = 0;
            List<ThanhToanDichVuView> listThanhToanPhongView = ThanhToanHoaDon_BLL.Instance.GetThanhToanDVView(IdPhong);
            foreach (ThanhToanDichVuView i in listThanhToanPhongView)
            {
                TongtienDV += i.TongTien;
            }
            lbTongGiaDV.Text = TongtienDV.ToString();
            lbTienTraTruoc.Text = data.TienTraTruoc.ToString();
            lbTongTien.Text = (Convert.ToInt32(lbGiaPhong.Text) + TongtienDV + data.TienTraTruoc).ToString();
            SetSTT();
        }

        private void formThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            ShowView();

        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ThanhToanDichVuView data = (ThanhToanDichVuView)dataGridView.SelectedRows[0].DataBoundItem;
            txtMaDichVu.Text = data.MaDichVu.ToString();
            foreach (CBBItem i in cbbTenDV.Items)
            {
                if (i.Text == data.TenDichVu)
                {
                    cbbTenDV.SelectedItem = i;
                }
            }
            txtSoLuong.Text = data.SoLuong.ToString();
            txtDonGia.Text = data.DonGia.ToString();
            dateTimePicker1.Value = data.NgaySuDung;
        }

        private void btnDatLaiTxt_Click(object sender, EventArgs e)
        {
            cbbTenDV.Enabled = true;
            txtSoLuong.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Enabled = true;
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    List<ThanhToanDichVuView> data = new List<ThanhToanDichVuView>();
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        data.Add((ThanhToanDichVuView)row.DataBoundItem);
                    }
                    ThanhToanHoaDon_BLL.Instance.DelChiTietDichVu(data, IdPhong);
                    this.btnDatLaiTxt_Click(sender, e);
                    ShowView();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại");
            }


        }

        private void btnAddDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbTenDV.SelectedItem == null)
                {
                    MessageBox.Show("Lỗi nhập thông tin");
                    return;
                }

                if (ThanhToanHoaDon_BLL.Instance.checkData(((CBBItem)cbbTenDV.SelectedItem).Value, dateTimePicker1.Value))
                {
                    MessageBox.Show("Dịch vụ đã có trong danh sách");
                    return;
                }
                try
                {
                    ThanhToanHoaDon_BLL.Instance.AddChiTietDichVu(new ChiTietSuDungDichVu
                    {
                        ID_Phong = IdPhong.ToString(),
                        ID_DichVu = ((CBBItem)cbbTenDV.SelectedItem).Value.ToString(),
                        ID_HoaDon = ThanhToanHoaDon_BLL.Instance.GetHoaDonByIdPhong(IdPhong).IdHoaDon.ToString(),
                        NgaySuDung = Convert.ToDateTime(dateTimePicker1.Value.Date),
                        SoLuong = Convert.ToInt32(txtSoLuong.Text),
                        TrangThai = false,
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại");
                }

                btnDatLaiTxt_Click(sender, e);
                ShowView();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi nhập thông tin");
            }
            
        }

        private void btnEditDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count == 1)
                {
                    ThanhToanDichVuView data = (ThanhToanDichVuView)dataGridView.SelectedRows[0].DataBoundItem;
                    data.MaDichVu = ((CBBItem)cbbTenDV.SelectedItem).Value.ToString();
                    data.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    data.NgaySuDung = Convert.ToDateTime(dateTimePicker1.Value.Date);
                    ThanhToanHoaDon_BLL.Instance.UpdateChiTietDichVu(data, IdPhong);
                    ShowView();
                    btnDatLaiTxt_Click(sender, e);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Sửa thất bại");
            }


        }

        private void cbbTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IdDichVu = ((CBBItem)cbbTenDV.SelectedItem).Value.ToString();
            DichVu dv = ThanhToanHoaDon_BLL.Instance.GetDichVuByIdDV(IdDichVu);
            txtDonGia.Text = dv.DonGia.ToString();
            txtMaDichVu.Text = dv.IdDichVu.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanHoaDon_BLL.Instance.GetHoaDonByIdPhong(IdPhong).TinhTrang = true;
            ThanhToanHoaDon_BLL.Instance.GetChiTietThuePhongByIdPhong(IdPhong).TrangThai = true;
            ThanhToanHoaDon_BLL.Instance.GetCtSDDVByIdPhong(IdPhong).TrangThai = true;
            ThanhToanHoaDon_BLL.Instance.GetChiTietBookByIdPhong(IdPhong).TrangThai = true;
            ThanhToanHoaDon_BLL.Instance.SetTTPhong(IdPhong);

            reload();


            MessageBox.Show("Hóa đơn đã được thanh toán");
            this.Close();
        }
    }
}
