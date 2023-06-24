using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ChiTietThuePhong
    {
        [Key, Required]
        public int IdChiTietThuePhong { get; set; }
        [StringLength(10), Required]
        public string IDHoaDon { get; set; }
        [StringLength(10), Required]
        public string IDPhong { get; set; }
        //[StringLength(10), Required]
        //public string IdNhanVien { get; set; }
        [Required]
        public Nullable<DateTime> NgayCheckIn { get; set; }
        [Required]
        public Nullable<DateTime> NgayCheckOut { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        [Required]
        public int DonGia { get; set; }
        [ForeignKey("IDHoaDon")]
        public virtual HoaDon HoaDon { get; set; }
        [ForeignKey("IDPhong")]
        public virtual Phong Phong { get; set; }
        //[ForeignKey("IdNhanVien")]
        //public virtual NhanVien NhanVien { get; set; }

    }
}
