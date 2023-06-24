using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
namespace PBL3.BLL
{
    public class BLL_TimPhongDeThue
    {
        private static BLL_TimPhongDeThue _Instance;
        QLKS db = new QLKS();
        public static BLL_TimPhongDeThue Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_TimPhongDeThue();
                }
                return _Instance;
            }
            private set { }
        }

        public List<Phong> getPhong(DateTime checkin,DateTime checkout)
        {
            List<Phong> data = new List<Phong>();
            foreach(var i in db.Phongs.Select(p => p))
            {
                foreach(var j in db.ChiTietThuePhongs.Select(p => p))
                {
                    
                }
            }

            return data;
        }

    }
}
