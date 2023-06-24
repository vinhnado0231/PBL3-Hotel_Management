using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class Book
    {
        public Book()
        {
            this.ChiTietBooks = new HashSet<ChiTietBook>();
        }

        [Key, StringLength(10), Required]
        public string IdBook { get; set; }
        [Required, StringLength(10)]
        public string IdKhachHang { get; set; }
        [Required, StringLength(10)]
        public string IdNhanVien { get; set; }
        public int TienCoc { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        [ForeignKey("IdKhachHang")]
        public virtual KhachHang KhachHang { get; set; }
        public virtual ICollection<ChiTietBook> ChiTietBooks { get; set; }
        [ForeignKey("IdNhanVien")]
        public virtual NhanVien NhanVien { get; set; }

    }
}
