using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class NhanVien
    {
        public NhanVien()
        {
            //this.ChiTietThuePhongs = new HashSet<ChiTietThuePhong>();
            this.LichSuDangNhaps = new HashSet<LichSuDangNhap>();
            this.HoaDons = new HashSet<HoaDon>();
            this.Books = new HashSet<Book>();
        }
        [Key, StringLength(10), Required]
        public string IdNhanVien { get; set; }
        [StringLength(10), Required]
        public string IdChucVu { get; set; }
        [StringLength(10), Required]
        public string IdTaiKhoan { get; set; }
        [Required]
        public string Ten { get; set; }
        [Required]
        public bool GioiTinh { get; set; }
        [Required]
        public string CMND { get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public Nullable<DateTime> NgayVaoLam { get; set; }
        [ForeignKey("IdChucVu")]
        public virtual ChucVu ChucVu { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        [ForeignKey("IdTaiKhoan")]
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        //public virtual ICollection<ChiTietThuePhong> ChiTietThuePhongs { get; set; }
        public virtual ICollection<LichSuDangNhap> LichSuDangNhaps { get; set; }

    }
}
