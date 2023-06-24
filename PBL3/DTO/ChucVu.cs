using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ChucVu
    {
        public ChucVu()
        {
            this.NhanViens = new HashSet<NhanVien>();
        }
        [Key, StringLength(10), Required]
        public string IdChucVu { get; set; }
        [Required]
        public string TenChucVu { get; set; }

        public virtual ICollection<NhanVien> NhanViens{ get; set; }

    }
}
