using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan()
        {
            this.NhanViens = new HashSet<NhanVien>();
        }
        [Key, StringLength(10), Required]
        public string IdTaiKhoan { get; set; }
        [StringLength(10), Required]
        public string TenDangNhap { get; set; }
        [Required]
        public string MatKhau { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
