using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiCSDL.ViewModel
{
    public class ProductChiTiet
    {
        public long ID { set; get; }

        public string Name { set; get; }
        public string Image { set; get; }
        public decimal? Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public string DuongKinhMat { set; get; }
        public string DoChiuNuoc { set; get; }
        public string ChatLieuMat { set; get; }
        public string Metatitle { set; get; }
        public DateTime? CreatedDate { set; get; }
        public double? sell { set; get; }
        public long? CategoryID { set; get; }
        public long? ParentID { set; get; }
    }
}
