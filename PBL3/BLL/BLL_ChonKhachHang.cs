using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLL_ChonKhachHang
    {

        private static BLL_ChonKhachHang _Instance;
        QLKS db = new QLKS();
        public static BLL_ChonKhachHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ChonKhachHang();
                }
                return _Instance;
            }
            private set { }
        }
        public List<KhachHangView> getAllKhachHang()
        {
            List<KhachHangView> data = new List<KhachHangView>();
            foreach(var i in db.KhachHangs.Select(p => p))
            {
                string gt = "Nam";
                if (i.GioiTinh == false) gt = "Nữ";
                data.Add(new KhachHangView
                {
                    IdKhachHang=i.IdKhachHang,
                    Ten=i.Ten,
                   GioiTinh=gt,
                    CMND=i.CMND,
                    SDT=i.SDT,
                    QuocTich=i.QuocTich,
                    NgaySinh=i.NgaySinh
                    
                });
            }
            return data;
        }
        public List<KhachHangView> searchbyName(string name)
        {
            List<KhachHangView> data = new List<KhachHangView>();
            foreach (var i in db.KhachHangs.Select(p => p))
            {
                if (i.Ten.Contains(name))
                {
                    string gt = "Nam";
                    if (i.GioiTinh == false) gt = "Nữ";
                    data.Add(new KhachHangView
                    {
                        IdKhachHang = i.IdKhachHang,
                        Ten = i.Ten,
                        GioiTinh = gt,
                        CMND = i.CMND,
                        SDT = i.SDT,
                        QuocTich = i.QuocTich

                    });
                }
            }
            return data;
        }
        public List<KhachHangView> searchbySDT(string SDT)
        {
            List<KhachHangView> data = new List<KhachHangView>();
            foreach (var i in db.KhachHangs.Select(p => p))
            {
                if (i.SDT.Contains(SDT))
                {
                    string gt = "Nam";
                    if (i.GioiTinh == false) gt = "Nữ";
                    data.Add(new KhachHangView
                    {
                        IdKhachHang = i.IdKhachHang,
                        Ten = i.Ten,
                        GioiTinh = gt,
                        CMND = i.CMND,
                        SDT = i.SDT,
                        QuocTich = i.QuocTich

                    });
                }
            }
            return data;
        }
        public List<KhachHangView> searchbyCMND(string CMND)
        {
            List<KhachHangView> data = new List<KhachHangView>();
            foreach (var i in db.KhachHangs.Select(p => p))
            {
                if (i.CMND.Contains(CMND))
                {
                    string gt = "Nam";
                    if (i.GioiTinh == false) gt = "Nữ";
                    data.Add(new KhachHangView
                    {
                        IdKhachHang = i.IdKhachHang,
                        Ten = i.Ten,
                        GioiTinh = gt,
                        CMND = i.CMND,
                        SDT = i.SDT,
                        QuocTich = i.QuocTich
                    });
                }
            }
            return data;
        }
       
    }
}
