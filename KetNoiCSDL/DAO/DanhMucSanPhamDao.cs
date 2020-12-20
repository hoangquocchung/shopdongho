using KetNoiCSDL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiCSDL.DAO
{
    public class DanhMucSanPhamDao
    {
        
        KetNoiDaTaBase db = null;
        public DanhMucSanPhamDao()
        {
            db = new KetNoiDaTaBase();
        }public List<DanhMucSanPham> ListBydanhmuc()
        {
            return db.DanhMucSanPhams.OrderByDescending(x=>x.DisplayOrder).ToList();
        }
    }
}
