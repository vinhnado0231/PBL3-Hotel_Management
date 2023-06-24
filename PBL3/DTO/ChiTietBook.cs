using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ChiTietBook
    {

        [StringLength(10), Required]
        public string IdPhong { get; set; }
        [Key, Required]
        public int IdChiTietBook { get; set; }
        [StringLength(10), Required]
        public string IdBook { get; set; }
        [Required]
        public Nullable<DateTime> NgayCheckInPhong { get; set;}      
        public Nullable<DateTime> NgayCheckOut { get; set;}
        [Required]
        public bool TrangThai { get; set; }
        [ForeignKey("IdBook")]
        public virtual Book Book { get; set; }
        [ForeignKey("IdPhong")]
        public virtual Phong Phong { get; set; }

    }
}
