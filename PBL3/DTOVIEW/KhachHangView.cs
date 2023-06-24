using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class KhachHangView
    {
        public string IdKhachHang { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string QuocTich { get; set; }
        public string GhiChu { get; set; }
    }
}
