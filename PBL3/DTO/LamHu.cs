using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class LamHu
    {
        [Key, StringLength(10), Required]
        public string ID_HoaDon { get; set; }
        [StringLength(10), Required]
        public string Id_Phong { get; set; }
        [StringLength(10), Required]
        public string ID_LoaiVatDung { get; set; }
        public int SoLuongLamHu { get; set; }
        [ForeignKey("ID_HoaDon")]
        public virtual HoaDon HoaDon { get; set; }
        [ForeignKey("ID_LoaiVatDung")]
        public virtual LoaiVatDung LoaiVatDung { get; set; }
        [ForeignKey("Id_Phong")]
        public virtual Phong Phong { get; set; }
    }
}
