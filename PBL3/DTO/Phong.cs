using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Phong
    {
        public Phong()
        {
            this.ChiTietBooks = new HashSet<ChiTietBook>();
            this.VatDungPhongs = new HashSet<VatDungPhong>();
            this.LamHus = new HashSet<LamHu>();
            this.ChiTietThuePhongs = new HashSet<ChiTietThuePhong>();
            this.ChiTietSuDungDichVus = new HashSet<ChiTietSuDungDichVu>();
        }

        [Key, StringLength(10), Required]
        public string IdPhong { get; set; }
        [Required]
        public string TenPhong { get; set; }
        [StringLength(10), Required]
        public string IdLoaiPhong { get; set; }
        [Required]
        public bool TrangThai { get; set; }
        [Required]
        public int DonGiaPhong { get; set; }

        public virtual ICollection<ChiTietBook> ChiTietBooks { get; set; }
        [ForeignKey("IdLoaiPhong")]
        public virtual LoaiPhong LoaiPhong { get; set; }
        public virtual ICollection<VatDungPhong> VatDungPhongs { get; set; }
        public virtual ICollection<LamHu> LamHus { get; set; }
        public virtual ICollection<ChiTietThuePhong> ChiTietThuePhongs { get; set; }
        public virtual ICollection<ChiTietSuDungDichVu> ChiTietSuDungDichVus { get; set; }
    }
}
