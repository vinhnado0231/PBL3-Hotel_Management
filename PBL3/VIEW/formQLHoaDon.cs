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
using PBL3.DTOVIEW;
using PBL3.DTO;
using PBL3.DAL;
using System.Reflection;

namespace PBL3.VIEW
{
    public partial class formQLHoaDon : Form
    {
        public formQLHoaDon()
        {
            InitializeComponent();
            setCbb();
        }


        public void showDataView(string txt, string loaiTimKiem, DateTime From, DateTime To)
        {
            dataGridViewHoaDon.DataSource = QLHoaDon_BLL.Instance.getAllHoaDonView(txt, loaiTimKiem, From, To).ToList();
            setSTT();
        }

        public void setSTT()
        {
            for (int i = 0; i < dataGridViewHoaDon.Rows.Count; i++)
            {
                dataGridViewHoaDon.Rows[i].Cells["STT"].Value = i + 1;
            }

            for (int i = 0; i < dataGridViewThuePhong.Rows.Count; i++)
            {
                dataGridViewThuePhong.Rows[i].Cells["STT1"].Value = i + 1;
            }

            for (int i = 0; i < dataGridViewDV.Rows.Count; i++)
            {
                dataGridViewDV.Rows[i].Cells["STT2"].Value = i + 1;
            }
        }

        private void formQLHoaDon_Load(object sender, EventArgs e)
        {
            showDataView("", "", new DateTime(), new DateTime());
        }


        private void dataGridViewHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idHoaDon = ((HoaDonView)dataGridViewHoaDon.SelectedRows[0].DataBoundItem).IdHoaDon;


            dataGridViewThuePhong.DataSource = QLHoaDon_BLL.Instance.getAllChiTietThuePhongView(idHoaDon).ToList();
            setSTT();
            dataGridViewDV.DataSource = QLHoaDon_BLL.Instance.getAllChiTietDVView(idHoaDon).ToList();
            setSTT();

        }

        public void setCbb()
        {
            List<CBBItem> list = new List<CBBItem>();
            HoaDonView temp = new HoaDonView();

            for (int i = 1; i < dataGridViewHoaDon.Columns.Count; i++)
            {
                list.Add(new CBBItem { Text = dataGridViewHoaDon.Columns[i].HeaderText, Value = "" });
            }
            for (int i = 0; i < temp.GetType().GetProperties().Length; i++)
            {
                list[i].Value = temp.GetType().GetProperties()[i].Name;
            }
            foreach (CBBItem item in list)
            {

                searchCbb.Items.Add(item);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showDataView(searchTxt.Text, ((CBBItem)searchCbb.SelectedItem).Value, new DateTime(), new DateTime());
            
        }

        private void datLaiBtn_Click(object sender, EventArgs e)
        {
            showDataView("", "", new DateTime(), new DateTime());
            searchTxt.Text = "";
            searchCbb.SelectedItem = null;
            showDataView("", "", new DateTime(), new DateTime());

        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            showDataView("", "", dateTimeFrom.Value, dateTimeTo.Value);
        }

        private void filterSearchBtn_Click(object sender, EventArgs e)
        {
            if (searchCbb.SelectedItem == null)
            {
                showDataView(searchTxt.Text, "", dateTimeFrom.Value, dateTimeTo.Value);

            }
            else
            {
                showDataView(searchTxt.Text, ((CBBItem)searchCbb.SelectedItem).Value, dateTimeFrom.Value, dateTimeTo.Value);

            }
        }
    }
}
