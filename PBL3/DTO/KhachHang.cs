using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class KhachHang
    {
        public KhachHang()
        {
            this.Books = new HashSet<Book>();
            this.HoaDons = new HashSet<HoaDon>();

        }
        [Key, StringLength(10), Required]
        public string IdKhachHang { get; set; }
        [Required]
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        [Required]
        public string CMND { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        [Required]
        public string QuocTich { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}

