using PBL3.BLL;
using Room;
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
    public partial class _formHome : Form
    {
        public _formHome()
        {
            InitializeComponent();
            setTTPhong();

        }

        public void setTTPhong()
        {
            foreach(RoomHotel i in flowLayoutPanelTang1.Controls.OfType<RoomHotel>())
            {
               
               if (BLL_ThuePhong.Instance.CheckTrangThaiPhong(i.Tag.ToString()))
                {
                    i.roomStatus = "Phòng Trống";
                    i.BackColor = System.Drawing.Color.LightSeaGreen;
                    i.ChangePic(1);


                }
                else
                {
                    i.roomStatus = "Phòng Có Khách";
                    i.BackColor = System.Drawing.Color.Orange;
                    i.ChangePic(0);
                }
                
            }
            foreach (RoomHotel i in flowLayoutPanelTang2.Controls.OfType<RoomHotel>())
            {
                if (BLL_ThuePhong.Instance.CheckTrangThaiPhong(i.Tag.ToString()))
                {
                    i.roomStatus = "Phòng Trống";
                    i.BackColor = System.Drawing.Color.LightSeaGreen;
                    i.ChangePic(1);
                }
                else
                {
                    i.roomStatus = "Phòng Có Khách";
                    i.BackColor = System.Drawing.Color.Orange;
                    i.ChangePic(0);
                }

            }
            foreach (RoomHotel i in flowLayoutPanelTang3.Controls.OfType<RoomHotel>())
            {
                if (BLL_ThuePhong.Instance.CheckTrangThaiPhong(i.Tag.ToString()))
                {
                    i.roomStatus = "Phòng Trống";
                    i.BackColor = System.Drawing.Color.LightSeaGreen;
                    i.ChangePic(1);
                }
                else
                {
                    i.roomStatus = "Phòng Có Khách";
                    i.BackColor = System.Drawing.Color.Orange;
                    i.ChangePic(0);
                }

            }
        }

        private void flowLayoutPanelTang3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelTang2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelTang1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomHotel1_Load(object sender, EventArgs e)
        {
        }
        public void roomDoubleClick(object sender,MouseEventArgs e)
        {
            
            if (((RoomHotel)sender).roomStatus == "Phòng Trống")
            {
                ((RoomHotel)sender).BackColor = System.Drawing.Color.Orange;
                ((RoomHotel)sender).roomStatus = "Đang có khách";
                ((RoomHotel)sender).ChangePic(0);
            }
            else
            {
                ((RoomHotel)sender).BackColor = System.Drawing.Color.LightSeaGreen;
                ((RoomHotel)sender).roomStatus = "Phòng Trống";
                ((RoomHotel)sender).ChangePic(1);
            }
        }
        private void roomHotel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel13_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void roomHotel7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            roomDoubleClick(sender, e);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            formThuePhongcs f = new formThuePhongcs(((RoomHotel)contextMenuStrip1.SourceControl).Tag.ToString());
            f.dd = new formThuePhongcs.Mydel(setTTPhong);

            f.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Items[0].Enabled = true;
            contextMenuStrip1.Items[1].Enabled = true;
            if (((RoomHotel)contextMenuStrip1.SourceControl).roomStatus== "Phòng Có Khách")
            {
                contextMenuStrip1.Items[0].Enabled = false;


            }
            else if (((RoomHotel)contextMenuStrip1.SourceControl).roomStatus == "Phòng Trống")
            {
                contextMenuStrip1.Items[1].Enabled = false;
            }
            

        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTraPhong f = new formTraPhong(((RoomHotel)contextMenuStrip1.SourceControl).Tag.ToString());
            f.reload += new formTraPhong.Mydel(setTTPhong);

            f.Show();
        }
        public void Showw() {
            foreach (RoomHotel i in flowLayoutPanelTang1.Controls.OfType<RoomHotel>())
            {

                if (BLL_ThuePhong.Instance.CheckTrangThaiPhong(i.Tag.ToString()))
                {
                    i.roomStatus = "Phòng Trống";
                    i.BackColor = System.Drawing.Color.LightSeaGreen;
                    i.ChangePic(1);
                }
                else
                {
                    i.roomStatus = "Phòng Có Khách";
                    i.BackColor = System.Drawing.Color.Orange;
                    i.ChangePic(0);
                }

            }
        }
        private void _formHome_Load(object sender, EventArgs e)
        {
            setTTPhong();
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            formDatPhong f = new formDatPhong();
            f.Show();
        }
    }
}
