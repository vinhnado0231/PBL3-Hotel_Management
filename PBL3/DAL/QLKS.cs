using PBL3.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace PBL3.DAL
{
    public class QLKS : DbContext
    {

        //private static QLKS _Instance;
        //public static QLKS Instance
        //{
        //    get
        //    {
        //        if (_Instance == null)
        //        {
        //            _Instance = new QLKS();
        //        }
        //        return _Instance;
        //    }
        //    set { }
        //}

        public QLKS()
            : base("name=QLKS")
        {
            Database.SetInitializer<QLKS>(new CreateDB());
        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<ChiTietBook> ChiTietBooks { get; set; }
        public virtual DbSet<ChiTietSuDungDichVu> ChiTietSuDungDichVus { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LamHu> LamHus { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<LoaiVatDung> LoaiVatDungs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<ChiTietThuePhong> ChiTietThuePhongs { get; set; }
        public virtual DbSet<LichSuDangNhap> LichSuDangNhaps { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<VatDungPhong> VatDungPhongs { get; set; }
    }

}