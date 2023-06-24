using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class DichVu
    {
        public DichVu()
        {
            this.ChiTietSuDungDichVus = new HashSet<ChiTietSuDungDichVu>();
        }
        [Key, StringLength(10), Required]
        public string IdDichVu { get; set; }
        [Required]
        public string TenDichVu { get; set; }
        [Required]
        public string DonGia { get; set; }
        public virtual ICollection<ChiTietSuDungDichVu> ChiTietSuDungDichVus { get; set; }
    }
}
