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
using PBL3.DTO;
using PBL3.DTOVIEW;

namespace PBL3.VIEW
{
    public partial class formThuePhongcs : Form
    {
        List<DichVuPhongView> data = new List<DichVuPhongView>();
        string idphong;
        public delegate void Mydel();
        public Mydel dd;
        public formThuePhongcs(string m)
        {
            idphong = m;
            InitializeComponent();
            dataGridViewDichVu.DataSource = BLL_ThuePhong.Instance.getAllDichVu();
            cbbTenPhong.Items.AddRange(BLL_ThuePhong.Instance.getAllPhong().ToArray());
            txtDatTien.Enabled = false;
            if(idphong!= "")
            {
                foreach (CBBItemPhong i in cbbTenPhong.Items)
                {
                    if (i.Value == idphong.ToString()) cbbTenPhong.SelectedItem = i;
                }
            }

        }
        public void setThongtinKhachHang(string MaKH)
        {
            dataGridViewKhachHang.DataSource = BLL_ThuePhong.Instance.getKhachHangByMaKH(MaKH);
        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewDichVu.DataSource = BLL_ThuePhong.Instance.getDVbySearch(txtSearch.Text);
        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTenPhong.Items.Clear();
        }

        private void butChonKhachHang_Click(object sender, EventArgs e)
        {
            formChonKhachHang f = new formChonKhachHang();
            f.d = new formChonKhachHang.Mydel(setThongtinKhachHang);
            f.Show();
        }


        private void formThuePhongcs_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtDatTien.Enabled = true;
            }
            else
            {
                txtDatTien.Enabled = false;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (cbbTenPhong.SelectedItem == null)
            {
                MessageBox.Show("VUI LÒNG CHỌN PHÒNG!");
                return;
            }
            if (data.Count == 0)
            {
                data.Add(BLL_ThuePhong.Instance.getDVPhongbyMaDV(dataGridViewDichVu.SelectedRows[0].Cells["IdDichVu"].Value.ToString()));
                dataGridViewDichVuPhong.DataSource = null;
                dataGridViewDichVuPhong.DataSource = data;
                return;
            }
            foreach (DichVuPhongView j in data)
            {
                if (j.IdDichVu == dataGridViewDichVu.SelectedRows[0].Cells["IdDichVu"].Value.ToString())
                {
                    j.SoLuong++;
                    j.ThanhTien = j.SoLuong * Convert.ToInt32(j.DonGia);
                    dataGridViewDichVuPhong.DataSource = null;
                    dataGridViewDichVuPhong.DataSource = data;
                    return;
                }

            }
            data.Add(BLL_ThuePhong.Instance.getDVPhongbyMaDV(dataGridViewDichVu.SelectedRows[0].Cells["IdDichVu"].Value.ToString()));

            if (data.Count > 0)
            {
                dataGridViewDichVuPhong.DataSource = null;
                dataGridViewDichVuPhong.DataSource = data;
            }
            TinhTien();
        }

        private void dataGridViewDichVuPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (cbbTenPhong.SelectedItem == null)
            {
                MessageBox.Show("VUI LÒNG CHỌN PHÒNG!");
                return;
            }
            formTimeLine f = new formTimeLine(((CBBItemPhong)cbbTenPhong.SelectedItem).Value);
            f.d = new formTimeLine.Mydel(SetDayCheckOut);
            f.Show();
        }
        public void SetDayCheckOut(DateTime d)
        {
            dateTimePicker2.Value = d;
        }
        public void TinhTien()
        {
            if (cbbTenPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng");
                return;
            }
            int tongtien = BLL_ThuePhong.Instance.getDonGiaPhong(((CBBItemPhong)cbbTenPhong.SelectedItem).Value);
            txtTienPhong.Text = tongtien.ToString();
            int tiendichvu = 0;
            foreach (DichVuPhongView i in data)
            {
                tongtien += Convert.ToInt32(i.DonGia) * i.SoLuong;
                tiendichvu += Convert.ToInt32(i.DonGia) * i.SoLuong;
            }
            txtTienDichVu.Text = tiendichvu.ToString();
            txtTongTien.Text = tongtien.ToString();
        }

        private void txtDatTien_TextChanged(object sender, EventArgs e)
        {
            txtDaDat.Text = txtDatTien.Text;
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (CheckNgoaiLe()==false)
            {
                MessageBox.Show("Thiếu thông tin !");
                return;
            }
            string idkhach = dataGridViewKhachHang.Rows[0].Cells["IdKhachHang"].Value.ToString();
            string idnhanvien = BLL_ThuePhong.Instance.getIDNhanVien();
            int tiendattruoc = 0;
            if (txtDaDat.Text.Length > 0)
            {
                tiendattruoc += Convert.ToInt32(txtDaDat.Text);
            }
         BLL_ThuePhong.Instance.TaoHoaDon(idkhach, idnhanvien, tiendattruoc);
           BLL_ThuePhong.Instance.TaoChiThietThuePhong(idkhach,((CBBItemPhong)cbbTenPhong.SelectedItem).Value, dateTimePicker1.Value, dateTimePicker2.Value);
            TaoChiTietSuDungDichVu(idkhach);
            BLL_ThuePhong.Instance.SetTTPhong(idphong);
            MessageBox.Show("Thuê phòng thành công ");
            dd();
            this.Close();
        }

        public void TaoChiTietSuDungDichVu(string idKhach)
        {
            foreach(DataGridViewRow i in dataGridViewDichVuPhong.Rows)
            {
               
                string iddv = i.Cells["IdDichVu"].Value.ToString();
                int sl =Convert.ToInt32(i.Cells["SoLuong"].Value.ToString());
             BLL_ThuePhong.Instance.TaoChiTietSuDungDichVu(idKhach, ((CBBItemPhong)cbbTenPhong.SelectedItem).Value,iddv,sl );
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewDichVuPhong_DataSourceChanged(object sender, EventArgs e)
        {
            TinhTien();
        }
        public bool CheckNgoaiLe()
        {
            if (cbbTenPhong.SelectedItem == null || dataGridViewKhachHang.Rows[0].Cells[0].Value ==null) return false;
            return true;
        }

        private void cbbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTien();

        }
       
    }
}
