using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class HoaDon
    {
        public HoaDon()
        {
           //this.LamHus = new HashSet<LamHu>();
            this.ChiTietThuePhongs = new HashSet<ChiTietThuePhong>();
            this.ChiTietSuDungDichVus = new HashSet<ChiTietSuDungDichVu>();
        }
        [Key, StringLength(10), Required]
        public string IdHoaDon { get; set; }
        [StringLength(10), Required]
        public string IDKhachHang { get; set; }
        [StringLength(10), Required]
        public string IDNhanVien { get; set; }
        [Required]
        public Nullable<DateTime> NgayHoaDon { get; set; }
        [Required]
        public bool TinhTrang { get; set; }
        public string GhiChu { get; set; }
        [Required]
        public int TienTraTruoc { get; set; }
        [ForeignKey("IDKhachHang")]
        public virtual KhachHang KhachHang { get; set; }
        [ForeignKey("IDNhanVien")]
        public virtual NhanVien NhanVien { get; set; }
        //public virtual ICollection<LamHu> LamHus { get; set; } 
        public virtual ICollection<ChiTietThuePhong> ChiTietThuePhongs { get; set; }    
        public virtual ICollection<ChiTietSuDungDichVu> ChiTietSuDungDichVus { get; set; }

    }
}
