using PBL3.BLL;
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
    public partial class formTimeLine : Form
    {
        public delegate void Mydel(DateTime ngay);
        public Mydel d { get; set; }
        public formTimeLine(string idphong)
        {
            InitializeComponent();

            //   ABC();
            cbbPhong.Items.AddRange(BLL_ThuePhong.Instance.getAllPhong().ToArray());
            foreach(CBBItemPhong i in cbbPhong.Items)
            {
                if(i.Value == idphong)
                {
                    cbbPhong.SelectedItem = i;
                }
            }
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                }
            }
            foreach (Control item in panel2.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                }
            }
            setLich();
            setNgay();
            label2.Text = "Ngày check in : "+DateTime.Now.Date.ToString();
        }
        public void setLich()
        {
            
            foreach (DateTime i in TimeLine_BLL.Instance.setNgay(((CBBItemPhong)cbbPhong.SelectedItem).Value))
            {
                string ngay = i.Day.ToString();
                string thang = i.Month.ToString();
                if (thang == DateTime.Now.Month.ToString())
                {
                    foreach (Control item in panel1.Controls)
                    {
                        if (item is Button)
                        {
                            if (item.Text == ngay)
                            {
                                item.Enabled = false;
                                item.ForeColor = Color.Tomato;
                            }
                        }
                    }
                }
                else
                {
                    foreach (Control item in panel2.Controls)
                    {
                        if (item is Button)
                        {
                            if (item.Text == ngay)
                            {
                                item.Enabled = false;
                                item.ForeColor = Color.Tomato;

                            }
                        }
                    }
                }
            }
        }
        public void setNgay()
        {
            int ngay = DateTime.Now.Day;
            //// Bất kì giá trị ngày tháng nào của bạn
            DateTime myDate = DateTime.Today;
            //// Ngày cuối cùng của tháng là ngày trước đó
            DateTime lastDayOfMonth = new DateTime(myDate.Year, myDate.Month, 1).AddMonths(1).AddDays(-1);
            int maxday = lastDayOfMonth.Day;
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {

                    if (Convert.ToInt32(item.Text) < ngay|| Convert.ToInt32(item.Text) >maxday)
                    {
                        item.Enabled = false;
                    }
                    if (item.Text == DateTime.Now.Day.ToString())
                    {
                        item.Enabled = false;
                        item.BackColor = Color.Tomato;
                        //return;
                    }
                   
                }
            }
            DateTime nextMonth = DateTime.Today.AddMonths(1);
            //// Ngày cuối cùng của tháng là ngày trước đó
            DateTime lastDayOfNextMonth = new DateTime(myDate.Year, myDate.Month, 1).AddMonths(1).AddDays(-1);
            int maxDayNextMonth = lastDayOfNextMonth.Day;
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if ( Convert.ToInt32(item.Text) > maxDayNextMonth)
                    {
                        item.Enabled = false;
                    }               
                }
            }
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formTimeLine_Load(object sender, EventArgs e)
        {

        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

            ThangHienTai_Click(sender, e);

        }
        private void ThangHienTai_Click(object sender, EventArgs e)
        {
            // dateTimePicker1.Value= DateTime.Now.AddDays(Convert.ToInt32(((Button)sender).Text));
            DateTime now = DateTime.Now;
            dateTimePicker1.Value = new DateTime(now.Year, now.Month, Convert.ToInt32(((Button)sender).Text));

        }
        private void ThangTiepTheo_Click(object sender, EventArgs e)
        {
            // dateTimePicker1.Value= DateTime.Now.AddDays(Convert.ToInt32(((Button)sender).Text));
            DateTime now = DateTime.Now;
            dateTimePicker1.Value = new DateTime(now.Year, now.Month+1, Convert.ToInt32(((Button)sender).Text));

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            d(dateTimePicker1.Value);
            this.Close();
        }
    }
}
