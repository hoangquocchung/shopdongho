using KetNoiCSDL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiCSDL.DAO
{
    public class MenuTopDao
    {
        KetNoiDaTaBase db = null;
        public MenuTopDao()
        {
            db = new KetNoiDaTaBase();
        }
        public List<DanhMucSanPham> ListDMSP()
        {
            return db.DanhMucSanPhams.Where(x => x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
        }
        public DanhMucSanPham ViewDetail(long id)
        {
            return db.DanhMucSanPhams.Find(id);
        }
    }
}
