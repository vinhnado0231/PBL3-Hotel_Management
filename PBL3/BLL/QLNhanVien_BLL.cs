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
    public class QLNhanVien_BLL
    {
        private static QLNhanVien_BLL _Instance;
        QLKS db = new QLKS();
        public static QLNhanVien_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLNhanVien_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        public QLNhanVien_BLL()
        {

        }
        public NhanVienView getNhanVienView(NhanVien i)
        {
            NhanVienView nhanVienView = new NhanVienView();
            nhanVienView.IdNhanVien = i.IdNhanVien;
            nhanVienView.Ten=i.Ten;
            nhanVienView.SDT=i.SDT;
            nhanVienView.CMND=i.CMND;
            nhanVienView.DiaChi=i.DiaChi;
            nhanVienView.NgayVaoLam = (DateTime)i.NgayVaoLam;
            nhanVienView.ChucVu = i.ChucVu.TenChucVu;
            nhanVienView.IdTaiKhoan = i.IdTaiKhoan;
            nhanVienView.TaiKhoan = i.TaiKhoan.TenDangNhap;
            nhanVienView.MatKhau = i.TaiKhoan.MatKhau;
            if (i.GioiTinh)
            {
                nhanVienView.GioiTinh = "Nam";
            }
            else
            {
                nhanVienView.GioiTinh = "Nữ";
            }
            return nhanVienView;
        }
        public List<NhanVienView> getAllNhanVien(string search,string sort)
        {
            var query = db.NhanViens.Select(p => p).ToList();
            if (sort == "Mã nhân viên")
            {
                query = db.NhanViens.OrderBy(p => p.IdNhanVien).ToList();
            }
            else if (sort == "Tên nhân viên")
            {
                query = db.NhanViens.OrderBy(p => p.Ten).ToList();
            }
            else if (sort == "Chức vụ")
            {
                query = db.NhanViens.OrderBy(p => p.ChucVu.TenChucVu).ToList();
            }
            else if (sort == "Tên tài khoản")
            {
                query = db.NhanViens.OrderBy(p => p.TaiKhoan.TenDangNhap).ToList();
            }
            List<NhanVienView> list = new List<NhanVienView>();
            if(search == "")
            {
                foreach (var item in query)
                {
                    list.Add(getNhanVienView(item));
                }
            }
            else
            {
                foreach (var item in query)
                {
                    if (item.IdNhanVien.Contains(search) || item.Ten.Contains(search) || item.DiaChi.Contains(search) || item.SDT.Contains(search) || item.CMND.Contains(search) || item.ChucVu.TenChucVu.Contains(search))
                    {
                        list.Add(getNhanVienView(item));
                    }                 
                }
            }
            return list;
        }
        public NhanVien findNhanVienById(string id)
        {
            var query = db.NhanViens.Select(p => p).ToList();
            foreach (var item in query)
            {
                if (id == item.IdNhanVien)
                {
                    return item;
                }
            }
            return null;
        }
        public void delete(string id)
        {
            foreach (NhanVien i in db.NhanViens.ToList())
            {
                if (i.IdNhanVien == id)
                {
                    try
                    {
                        db.NhanViens.Remove(i);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
            }
        }
        public void addOrUpdate(NhanVien nhanVien)
        {
            try
            {
                if (findNhanVienById(nhanVien.IdNhanVien) != null)
                {
                    var t = db.NhanViens.Where(p => p.IdNhanVien == nhanVien.IdNhanVien).FirstOrDefault();
                    t.CMND = nhanVien.CMND;
                    t.SDT = nhanVien.SDT;
                    t.NgayVaoLam = nhanVien.NgayVaoLam;
                    t.Ten = nhanVien.Ten;
                    t.GioiTinh = nhanVien.GioiTinh;
                    t.IdChucVu = nhanVien.IdChucVu;
                    t.ChucVu = nhanVien.ChucVu;
                    t.DiaChi = nhanVien.DiaChi;
                    t.IdTaiKhoan = nhanVien.IdTaiKhoan;
                    t.TaiKhoan = nhanVien.TaiKhoan;
                    db.SaveChanges();
                }
                else
                {
                    NhanVien nhanVien1 = db.NhanViens.Last();
                    nhanVien.IdTaiKhoan = (Convert.ToInt32(nhanVien1.IdTaiKhoan) + 1).ToString();
                    nhanVien.TaiKhoan.IdTaiKhoan = (Convert.ToInt32(db.NhanViens.LastOrDefault().IdTaiKhoan) + 1).ToString();
                    db.NhanViens.Add(nhanVien);
                    db.SaveChanges();
                }
            }catch (Exception ex)
            {

            }
        }


    }
}
