using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTOVIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class QLChucVu_BLL
    {
        private QLKS db = new QLKS();

        private static QLChucVu_BLL _Instance;
        public static QLChucVu_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLChucVu_BLL();
                }
                return _Instance;
            }
            set { }
        }

        public QLChucVu_BLL()
        {

        }
        public List<CBBItem> getCbbChucVu()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (var i in db.ChucVus.Select(p => p))
            {
                data.Add(new CBBItem { Text = i.TenChucVu, Value = i.IdChucVu });
            }
            return data;
        }

        public ChucVu getChucVuById(string id)
        {
            return db.ChucVus.Where(prop=>prop.IdChucVu == id).FirstOrDefault();
        }
    }
}
