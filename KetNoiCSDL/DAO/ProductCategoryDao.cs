using KetNoiCSDL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiCSDL.DAO
{
    public class ProductCategoryDao
    {
        KetNoiDaTaBase db = null;
        public ProductCategoryDao()
        {
            db = new KetNoiDaTaBase();
        }

        public DanhMucSanPham ViewDetail(long id)
        {
            return db.DanhMucSanPhams.Find(id);
        }
    }
}
