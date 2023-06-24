using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class TimeLine_BLL
    {
        private static TimeLine_BLL _Instance;
        QLKS db = new QLKS();
        public static TimeLine_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TimeLine_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        public List<DateTime> setNgay(string idphong)
        {
            List<DateTime> data = new List<DateTime>();
           // string idphong = "1P1";
            var c = db.Phongs.Find(idphong);
            foreach (var item in c.ChiTietThuePhongs)
            {
                TimeSpan Time = item.NgayCheckOut.Value - item.NgayCheckIn.Value;
                int songay = Time.Days;
                for(int i = 0; i <= songay; i++)
                {
                    data.Add(item.NgayCheckIn.Value.AddDays(+i));
                }
            }
            foreach(var item in c.ChiTietBooks)
            {
                TimeSpan Time = item.NgayCheckOut.Value - item.NgayCheckInPhong.Value;
                int songay = Time.Days;
                for (int i = 0; i <= songay; i++)
                {
                    data.Add(item.NgayCheckInPhong.Value.AddDays(+i));
                }
            }
            return data;
        }

    }
}
