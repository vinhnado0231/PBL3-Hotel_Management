using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ChiTietSuDungDichVu
    {
        [Key, Required]
        public int ID_ChiTietSuDungDichVu { get; set; }
        [StringLength(10), Required]
        public string ID_Phong { get; set; }
        [StringLength(10), Required]
        public string ID_DichVu { get; set; }
        [StringLength(10), Required]
        public string ID_HoaDon { get; set; }
        [Required]
        public Nullable<DateTime> NgaySuDung { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        [ForeignKey("ID_Phong")]
        public virtual Phong Phong { get; set; }
        [ForeignKey("ID_DichVu")]
        public virtual DichVu DichVu { get; set; }
        [ForeignKey("ID_HoaDon")]
        public virtual HoaDon HoaDon { get; set; }
    }
}
