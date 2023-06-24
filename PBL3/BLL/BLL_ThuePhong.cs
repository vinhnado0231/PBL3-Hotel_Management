using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTOVIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLL_ThuePhong
    {
        private static BLL_ThuePhong _Instance;
        QLKS db = new QLKS();
        public static BLL_ThuePhong Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ThuePhong();
                }
                return _Instance;
            }
            private set { }
        }
        public List<KhachHangView> getKhachHangByMaKH(string MaKH)
        {
           List<KhachHangView> data = new List<KhachHangView> ();
            foreach(var i in db.KhachHangs.Select(p => p))
            {
                if (i.IdKhachHang == MaKH)
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
        public List<DichVuView> getAllDichVu()
        {
            List<DichVuView> data = new List<DichVuView>();
            foreach (var i in db.DichVus.Select(p => p))
            {
                data.Add(new DichVuView
                {
                    IdDichVu = i.IdDichVu,
                    TenDichVu = i.TenDichVu,
                    DonGia = i.DonGia
                });
            }
            return data;
        }
        public List<DichVuView> getDVbySearch(string txt)
        {
            List<DichVuView> data = new List<DichVuView>();
            foreach (var i in db.DichVus.Select(p => p))
            {
                if (i.TenDichVu.Contains(txt))
                {
                    data.Add(new DichVuView
                    {
                        IdDichVu = i.IdDichVu,
                        TenDichVu = i.TenDichVu,
                        DonGia = i.DonGia
                    });
                }
            }
            return data;
        }
        public List<CBBItemPhong> getAllPhong()
        {
            List<CBBItemPhong> data = new List<CBBItemPhong>();
            foreach (var i in db.Phongs.Select(p => p))
            {
                data.Add(new CBBItemPhong
                {
                    Value = i.IdPhong,
                    Text = i.TenPhong,
                });
            }
            return data;
        }
        public DichVuPhongView getDVPhongbyMaDV(string MaDV)
        {
            foreach (var i in db.DichVus.Select(p => p))
            {
                if (i.IdDichVu == MaDV) 
                {
                    return new DichVuPhongView
                    {
                        IdDichVu = i.IdDichVu,
                        SoLuong = 1,
                        TenDichVu = i.TenDichVu,
                        DonGia = i.DonGia,
                        ThanhTien = Convert.ToInt32(i.DonGia)
                    };
                }
            }
            return null;
        }
        public int getDonGiaPhong(string idphong)
        {
            foreach(var i in db.Phongs.Select(p => p))
            {
                if (i.IdPhong == idphong)
                {
                    return Convert.ToInt32(i.DonGiaPhong);
                }
            }
            return 0;
        }
        public string getnewIDHoaDon()
        {
            string id = "";
            List<string> data = new List<string>();
            foreach(var i in db.HoaDons.Select(p => p).OrderBy(p=>p.IdHoaDon))
            {
                data.Add(i.IdHoaDon.Substring(2));
            }

            int idtt = Convert.ToInt32(data.Select(v => int.Parse(v)).Max()) + 1;
            id = "HD" + idtt.ToString();
            return id;
        }
        public string getIDNhanVien()
        {
            foreach(var i in db.NhanViens.Select(p => p))
            {
                if (i.TaiKhoan.TrangThai)
                {
                    return i.IdNhanVien;
                }
            }
            return null;
        }
        public bool CheckHoaDon(string idkhachhang)
        {
            foreach (var i in db.HoaDons.Select(p => p)){
                if(i.TinhTrang==false && i.IDKhachHang == idkhachhang)
                {
                    return true;
                }
            }
            return false;
        }
        public void TaoHoaDon(string idkhach,string idnhanvien,int tientratruoc)
        {
            if (CheckHoaDon(idkhach))
            {
                return;
            }
            HoaDon hoaDon = new HoaDon {
                IdHoaDon = getnewIDHoaDon(),
                IDKhachHang = idkhach,
                IDNhanVien = idnhanvien,
                TienTraTruoc = tientratruoc,
                TinhTrang = false,
                NgayHoaDon=DateTime.Now,
                GhiChu="",

            };
            db.HoaDons.Add(hoaDon);
            db.SaveChanges();
        }
        //public string getnewIDChiTietThuePhong()
        //{
        //    List<string> data = new List<string>();
        //    foreach (var i in db.ChiTietThuePhongs.Select(p => p).OrderBy(p => p.IdChiTietThuePhong))
        //    {
        //        data.Add(i.IdChiTietThuePhong.Substring(4));
        //    }
        //    int idtt = Convert.ToInt32(data.Select(v => int.Parse(v)).Max()) + 1;
        //    return "CTTP" + idtt.ToString();
        //}
        //public string getnewIDChiTietDichVu()
        //{
        //    List<string> data = new List<string>();
        //    foreach (var i in db.ChiTietSuDungDichVus.Select(p => p).OrderBy(p => p.ID_ChiTietSuDungDichVu))
        //    {
        //        data.Add(i.ID_ChiTietSuDungDichVu.Substring(4));
        //    }
        //    int idtt = Convert.ToInt32(data.Select(v => int.Parse(v)).Max()) + 1;
        //    return "CTTP" + idtt.ToString();
        //}
        public string getIdHoaDonByIdKhach(string idkhachhang)
        {
            foreach(var i in db.HoaDons.Select(p => p)){
                if (i.TinhTrang == false && i.IDKhachHang == idkhachhang)
                {
                    return i.IdHoaDon;
                }
            }
            return null; ;
        }
      
        public void TaoChiThietThuePhong(string idkhach,string idPhong,DateTime ngayCheckIn, DateTime ngayCheckOut)
        {
            if (getIdHoaDonByIdKhach(idkhach) == null) return;
            ChiTietThuePhong chitiet = new ChiTietThuePhong
            {
                IDHoaDon = getIdHoaDonByIdKhach(idkhach),
                NgayCheckIn = ngayCheckIn,
                NgayCheckOut = ngayCheckOut,
                DonGia = getDonGiaPhong(idPhong),
                IDPhong = idPhong,
                TrangThai = false,

            };
            db.ChiTietThuePhongs.Add(chitiet);
            db.SaveChanges();
        }
        public void TaoChiTietSuDungDichVu(string idKhach,string idPhong,string idDV,int soluong)
        {
            ChiTietSuDungDichVu s = new ChiTietSuDungDichVu
            {
              //  ID_ChiTietSuDungDichVu=getnewIDChiTietDichVu(),
                ID_Phong=idPhong,
                ID_DichVu=idDV,
                ID_HoaDon= getIdHoaDonByIdKhach(idKhach),
                NgaySuDung=DateTime.Now,
                SoLuong=soluong,

            };
            db.ChiTietSuDungDichVus.Add(s);
            db.SaveChanges();
        }
        public void SetTTPhong(string IdPhong)
        {
            var c = db.Phongs.Find(IdPhong);
            c.TrangThai = false;
            db.SaveChanges();

        }
        public bool CheckTrangThaiPhong(string IdPhong)
        {
            var c = db.Phongs.Find(IdPhong);
            return c.TrangThai;
        }
    }
}
