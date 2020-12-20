using KetNoiCSDL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiCSDL.DAO
{
    public class CommonTopDao
    {
        KetNoiDaTaBase db = null;
        public CommonTopDao()
        {
            db = new KetNoiDaTaBase();
        }
        public List<Menu> ListGroupId(int groupId)
        {
            return db.Menus.Where(x => x.typeID == groupId && x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
        }
    }
}
