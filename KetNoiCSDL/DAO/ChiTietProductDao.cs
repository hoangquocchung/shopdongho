using KetNoiCSDL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiCSDL.DAO
{
    public class ChiTietProductDao
    {
        KetNoiDaTaBase db = null;
        public ChiTietProductDao()
        {
            db = new KetNoiDaTaBase();
        }
        public ChitietSanpham ViewChiTietProduct(long id)
        {
            return db.ChitietSanphams.Find(id);
        }
    }
}
