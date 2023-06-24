using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class LoaiPhong
    {
        public LoaiPhong()
        {
            this.Phongs = new HashSet<Phong>();
        }
        [Key, StringLength(10), Required]
        public string IdLoaiPhong { get; set; }
        [Required]
        public string TenLoaiPhong { get; set; }
        [Required]
        public int SoNguoiToiDa { get; set; }
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
