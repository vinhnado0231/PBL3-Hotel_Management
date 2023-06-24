using PBL3.BLL;
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
    public partial class formChonKhachHang : Form
    {
        public delegate void Mydel(string a);
        public Mydel d;
        public formChonKhachHang()
        {
            InitializeComponent();
            dataGridView1.DataSource = BLL_ChonKhachHang.Instance.getAllKhachHang();
            comboBox1.SelectedIndex = 0;
        }

        private void butOK_Click(object sender, EventArgs e)
        {

            d(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            this.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void getKHBySearch()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = BLL_ChonKhachHang.Instance.searchbyName(txtSearch.Text);
            }else if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = BLL_ChonKhachHang.Instance.searchbySDT(txtSearch.Text);
            }
            else
            {
                dataGridView1.DataSource = BLL_ChonKhachHang.Instance.searchbyCMND(txtSearch.Text);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            getKHBySearch();
        }
    }
}
