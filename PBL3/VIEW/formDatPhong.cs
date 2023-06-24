using PBL3.BLL;
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

namespace PBL3.VIEW
{
    public partial class formDatPhong : Form
    {
        List<ChiTietBook> listchitiet = new List<ChiTietBook>();
        public formDatPhong()
        {
            InitializeComponent();
            labelIdBook.Text = DatPhong_BLL.Instance.getNewIDBook();
            labelIDNhanVien.Text = BLL_ThuePhong.Instance.getIDNhanVien();
            labelIDKhachHang.Text = "";
            txtDatTien.Enabled = false;
            setCBBChonPhong();
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }
        public void setCBBChonPhong()
        {
            cbbChonPhong.Items.AddRange(BLL_ThuePhong.Instance.getAllPhong().ToArray());
        }
        private void butChonKH_Click(object sender, EventArgs e)
        {
            formChonKhachHang f = new formChonKhachHang();
            f.d = new formChonKhachHang.Mydel(setThongtinKhachHang);
            f.Show();
        }
        public void setThongtinKhachHang(string MaKH)
        {
            dataGridViewKhachHang.DataSource = BLL_ThuePhong.Instance.getKhachHangByMaKH(MaKH);
            labelIDKhachHang.Text = dataGridViewKhachHang.Rows[0].Cells[0].Value.ToString();

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

        private void butChonCheckIn_Click(object sender, EventArgs e)
        {
            if (cbbChonPhong.SelectedItem == null)
            {
                MessageBox.Show("VUI LÒNG CHỌN PHÒNG!");
                return;
            }
            formTimeLine f = new formTimeLine(((CBBItemPhong)cbbChonPhong.SelectedItem).Value);
            f.d = new formTimeLine.Mydel(SetDayCheckIn);
            f.Show();
        }
        public void SetDayCheckIn(DateTime d)
        {
            dateTimePicker1.Value = d;
        }
        public void SetNgayCheckOut(DateTime d)
        {
            dateTimePicker2.Value = d;
            if (DatPhong_BLL.Instance.Check(((CBBItemPhong)cbbChonPhong.SelectedItem).Value, dateTimePicker1.Value, dateTimePicker2.Value) == false)
            {
                MessageBox.Show("Ngày Check Out Không Hợp Lệ");
                dateTimePicker2.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Hợp lệ");

            }

        }

        private void butChonCheckOut_Click(object sender, EventArgs e)
        {
            if (cbbChonPhong.SelectedItem == null)
            {
                MessageBox.Show("VUI LÒNG CHỌN PHÒNG!");
                return;
            }
            formTimeLine f = new formTimeLine(((CBBItemPhong)cbbChonPhong.SelectedItem).Value);
            f.d = new formTimeLine.Mydel(SetNgayCheckOut);
            f.Show();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            int tiencoc = 0;
            if (txtDatTien.Text != "") tiencoc = Convert.ToInt32(txtDatTien.Text);
            DatPhong_BLL.Instance.AddBook(labelIDKhachHang.Text,labelIDNhanVien.Text, tiencoc);

            DatPhong_BLL.Instance.AddChiTiet(listchitiet);
            this.Close();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            if (cbbChonPhong.SelectedItem == null || dateTimePicker1.Value.CompareTo(dateTimePicker2.Value)==0)
            {
                MessageBox.Show("Không hợp lệ !");
                return; 
            }
            ChiTietBook a = new ChiTietBook
            {
                IdPhong = ((CBBItemPhong)cbbChonPhong.SelectedItem).Value,
                IdBook=labelIdBook.Text,
                NgayCheckInPhong=dateTimePicker1.Value.Date,
                NgayCheckOut = dateTimePicker2.Value.Date,
                TrangThai=false,
            };
            listchitiet.Add(a);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listchitiet;
        }
    }
}
