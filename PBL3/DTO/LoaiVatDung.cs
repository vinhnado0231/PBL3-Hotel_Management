using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class LoaiVatDung
    {
        public LoaiVatDung()
        {
            this.VatDungPhongs = new HashSet<VatDungPhong>();
            this.LamHus = new HashSet<LamHu>();

        }
        [Key, StringLength(10), Required]
        public string IdLoaiVatDung { get; set; }
        [Required]
        public string TenVatDung { get; set; }
        [Required]
        public int DonGia { get; set; }
        public virtual ICollection<VatDungPhong> VatDungPhongs { get; set; }
        public virtual ICollection<LamHu> LamHus { get; set; }


    }
}
