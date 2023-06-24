using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLKhachHang_BLL
    {
        private QLKS db = new QLKS();
        private static QLKhachHang_BLL _Instance;
        public static QLKhachHang_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLKhachHang_BLL();
                }
                return _Instance;
            }
            set { }
        }

        public QLKhachHang_BLL()
        {

        }
        public KhachHangView getKhachHangView(KhachHang i)
        {
            KhachHangView khachHang = new KhachHangView();
            khachHang.IdKhachHang = i.IdKhachHang;
            khachHang.Ten = i.Ten;
            khachHang.CMND = i.CMND;
            khachHang.NgaySinh = i.NgaySinh;
            khachHang.SDT = i.SDT;
            khachHang.GhiChu = i.GhiChu;
            khachHang.QuocTich = i.QuocTich;
            if (i.GioiTinh)
            {
                khachHang.GioiTinh = "Nam";
            }
            else
            {
                khachHang.GioiTinh = "Nữ";
            }
            return khachHang;
        }

        public List<KhachHangView> getAllKhachHang(string search, string sort)
        {
            var query = db.KhachHangs.Select(p => p).ToList();
            if (sort == "Mã khách hàng")
            {
                query = db.KhachHangs.OrderBy(p => p.IdKhachHang).ToList();
            }
            else if (sort == "Tên khách hàng")
            {
                query = db.KhachHangs.OrderBy(p => p.Ten).ToList();
            }
            else if (sort == "Quốc tịch")
            {
                query = db.KhachHangs.OrderBy(p => p.QuocTich).ToList();
            }
            List<KhachHangView> list = new List<KhachHangView>();
            if (search == "")
            {
                foreach (var item in query)
                {
                    list.Add(getKhachHangView(item));
                }
            }
            else
            {
                foreach (var item in query)
                {
                    if (item.IdKhachHang.Contains(search))
                    {
                        list.Add(getKhachHangView(item));
                    }
                    if (item.Ten.Contains(search))
                    {
                        list.Add(getKhachHangView(item));
                    }
                    if (item.QuocTich.Contains(search))
                    {
                        list.Add(getKhachHangView(item));
                    }
                    if (item.SDT.Contains(search))
                    {
                        list.Add(getKhachHangView(item));
                    }
                    if (item.CMND.Contains(search))
                    {
                        list.Add(getKhachHangView(item));
                    }
                }
            }
            return list;
        }

        public KhachHang findKhachHangById(string id)
        {
            var query = db.KhachHangs.Select(p => p).ToList();
            foreach (var item in query)
            {
                if (id == item.IdKhachHang)
                {
                    return item;
                }
            }
            return null;
        }

        public void delete(string id)
        {
            foreach (KhachHang i in db.KhachHangs.ToList())
            {
                if (i.IdKhachHang == id)
                {
                    try
                    {
                        db.KhachHangs.Remove(i);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
            }
        }

        public void addOrUpdate(KhachHang khachHang)
        {
            if (findKhachHangById(khachHang.IdKhachHang) != null)
            {
                var t = db.KhachHangs.Where(p => p.IdKhachHang == khachHang.IdKhachHang).FirstOrDefault();
                t.CMND = khachHang.CMND;
                t.SDT = khachHang.SDT;
                t.NgaySinh = khachHang.NgaySinh;
                t.Ten = khachHang.Ten;
                t.GioiTinh = khachHang.GioiTinh;
                t.GhiChu = khachHang.GhiChu;
                t.QuocTich = khachHang.QuocTich;
                db.SaveChanges();
            }
            else
            {
                db.KhachHangs.Add(khachHang);
                db.SaveChanges();
            }
        }
    }
}
