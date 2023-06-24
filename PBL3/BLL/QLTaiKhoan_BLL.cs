using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLTaiKhoan_BLL
    {
        private QLKS db = new QLKS();

        private static QLTaiKhoan_BLL _Instance;
        public static QLTaiKhoan_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTaiKhoan_BLL();
                }
                return _Instance;
            }
            set { }
        }

        public QLTaiKhoan_BLL()
        {

        }
        public string getHash(string plainText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainText));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public string getPassword(string idNhanVien)
        {
            TaiKhoan taiKhoan = findTaiKhoanByIdNhanVien(idNhanVien);
            return taiKhoan.MatKhau;
        }

        public TaiKhoan findTaiKhoanByIdNhanVien(string id)
        {
            TaiKhoan taiKhoan = QLNhanVien_BLL.Instance.findNhanVienById(id).TaiKhoan;
            return taiKhoan;
        }

        public bool checkPassword(string idNhanVien, string password)
        {
            //string encrypt = getHash(password);
            //var t = findTaiKhoanByIdNhanVien(idNhanVien);
            //try
            //{
            //    if (t != null)
            //    {
            //        if (t.MatKhau == encrypt)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
            return false;
        }
        public void addOrUpdateAccount(TaiKhoan taiKhoan)
        {
            //TaiKhoan t = findTaiKhoanById(taiKhoan.IdNhanVien);
            //if (t != null)
            //{
            //    t.TenDangNhap = taiKhoan.TenDangNhap;
            //    t.MatKhau = taiKhoan.MatKhau;
            //    db.SaveChanges();
            //}
            //else
            //{
            //    taiKhoan.TrangThai = false;
            //    db.TaiKhoans.Add(taiKhoan);
            //    db.SaveChanges();
            //}
        }
    }
}
