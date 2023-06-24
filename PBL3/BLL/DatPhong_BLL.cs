using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class DatPhong_BLL
    {
        private QLKS db = new QLKS();

        private static DatPhong_BLL _Instance;
        public static DatPhong_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DatPhong_BLL();
                }
                return _Instance;
            }
            set { }
        }
        public string getNewIDBook()
        {
            List<string> data = new List<string>();
            foreach (var i in db.Books.Select(p => p).OrderBy(p => p.IdBook))
            {
                data.Add(i.IdBook.Substring(1));
            }
            int idtt = Convert.ToInt32(data.Select(v => int.Parse(v)).Max()) + 1;
            return "B" + idtt.ToString();
        }
        public bool Check(string idphong,DateTime dateTimePicker1,DateTime dateTimePicker2)
        {
            List<DateTime> data = TimeLine_BLL.Instance.setNgay(idphong);

            TimeSpan Time = dateTimePicker2.Date - dateTimePicker1.Date;
            int songay = Time.Days;
            if (songay < 0) return false;
            DateTime temp = dateTimePicker1;
            for (int i = 0; i <= songay; i++)
            {
                DateTime ngay = temp.AddDays(+i).Date;
                foreach (DateTime d in data)
                {
                    if (d.CompareTo(ngay) == 0)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
        public void AddBook(string idkhach,string idNV,int tien)
        {
            Book s = new Book
            {
                IdBook=getNewIDBook(),
                IdKhachHang = idkhach,
                IdNhanVien = idNV,
                TrangThai = false,
                TienCoc= tien,
            };
            db.Books.Add(s);
            db.SaveChanges();

        }
        public void AddChiTiet(List<ChiTietBook> data)
        {
            foreach(ChiTietBook i in data)
            {
                db.ChiTietBooks.Add(i);
            }
            db.SaveChanges();
        }
    }
}
