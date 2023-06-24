using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTOVIEW
{
    public class HoaDonView
    {
        public string IdHoaDon { get; set; }
        public string IDKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string IDNhanVien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public int TienTraTruoc { get; set; }
        public int TienPhong { get; set; }
        public int TongTienDV { get; set; }
        public int TongTien { get; set; }
        public int ThueVAT { get; set; }
        public bool TrangThai { get; set; }

    }
}
