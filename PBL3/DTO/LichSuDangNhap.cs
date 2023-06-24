using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class LichSuDangNhap
    {
        [Key, StringLength(10), Required]
        public string IDLichSu { get; set; }
        [StringLength(10), Required]
        public string IDNhanVien { get; set; }
        [Required]
        public Nullable<DateTime> ThoiGian { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        [ForeignKey("IDNhanVien")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
