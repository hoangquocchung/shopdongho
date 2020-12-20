using KetNoiCSDL.EF;
using KetNoiCSDL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiCSDL.DAO
{
    public class ProductDao
    {
        KetNoiDaTaBase db = null;
        public ProductDao()
        {
            db = new KetNoiDaTaBase();
        }
        public List<SanPham> ListNewProduct(int top)
        {
            return db.SanPhams.OrderByDescending(x => x.CreatedDate).Take(top).ToList();
        }


        // Bạn đang dùng cái hàm chitiet này, nó chỉ lấy 1 sản phẩm
        public List<ProductViewModel> Chitiet(long ChitietID,int top)
        {
            var model = from a in db.SanPhams
                        join b in db.ChitietSanphams
                        on a.ID equals b.ID
                        where a.ID == ChitietID
                        select new ProductViewModel()
                        {
                            Metatitle = a.MetaTitle,
                            Name = a.Name,
                            CreatedDate = a.CreatedDate,
                            ID = a.ID,
                            Image = a.Image,
                            Price = a.Price,
                            PromotionPrice = a.PromotionPrice,
                            DuongKinhMat = b.DuongKinhMat,
                            ChatLieuMat = b.ChatLieuMat,
                            DoChiuNuoc = b.DoChiuNuoc

                        };
            model.OrderByDescending(x => x.CreatedDate).Take(top);
            return model.ToList();
        }


        //lấy tất cả sanrt phẩm
        public List<ProductViewModel> GetAllChitiet(long IDDanhMuc, int top)
        {
            // IDDanhmuc để sau này bạn lấy danh sách sản phẩm theo danh mục 
            var model = from a in db.SanPhams
                        join b in db.ChitietSanphams
                        // Trong bảng SanPhams join với bảng ChitietSanphams
                        on a.ID equals b.ID
                        // Lấy các bản ghi mà SanPhams.ID = ChitietSanphams.ID
                        select new ProductViewModel()
                        {
                            Metatitle = a.MetaTitle,
                            Name = a.Name,
                            CreatedDate = a.CreatedDate,
                            ID = a.ID,
                            Image = a.Image,
                            Price = a.Price,
                            PromotionPrice = a.PromotionPrice,
                            sell = Math.Round((double)(100-(((a.Price+a.PromotionPrice)/a.Price*100)-100))),
                            DuongKinhMat = b.DuongKinhMat,
                            ChatLieuMat = b.ChatLieuMat,
                            DoChiuNuoc = b.DoChiuNuoc


                        };
                        // Mỗi bản ghi lấy được sẽ chuyển thành object ProductViewModel
            model.OrderByDescending(x => x.CreatedDate).Take(top);
            return model.ToList();
        }

        // lấy 1 danh sách sản phẩm
        public List<ProductChiTiet> ListByChitiet(long IDDanhMuc, int top)
        {
            // IDDanhmuc để sau này bạn lấy danh sách sản phẩm theo danh mục 
            var model = from a in db.SanPhams
                        join b in db.ChitietSanphams
                        // Trong bảng SanPhams join với bảng ChitietSanphams
                        on a.ID equals b.ID
                        join c in db.DanhMucSanPhams
                        on a.CategoryID equals c.ID
                        
                        // Lấy các bản ghi mà SanPhams.ID = ChitietSanphams.ID
                        select new ProductChiTiet()
                        {
                            Metatitle = a.MetaTitle,
                            Name = a.Name,
                            CreatedDate = a.CreatedDate,
                            ID = a.ID,
                            Image = a.Image,
                            Price = a.Price,
                            PromotionPrice = a.PromotionPrice,
                            sell = Math.Round((double)(100 - (((a.Price + a.PromotionPrice) / a.Price * 100) - 100))),
                            DuongKinhMat = b.DuongKinhMat,
                            ChatLieuMat = b.ChatLieuMat,
                            DoChiuNuoc = b.DoChiuNuoc,
                            ParentID = c.ParentID
                            
                        };
            // Mỗi bản ghi lấy được sẽ chuyển thành object ProductViewModel
            model.OrderByDescending(x => x.CreatedDate).Take(top);
            return model.ToList();
        }

        public SanPham ViewDetatil(long id)
        {
            return db.SanPhams.Find(id);
        }

        public List<SanPham> ListRelatedProduct(long productid)
        {
            var product = db.SanPhams.Find(productid);
            return db.SanPhams.Where(x => x.ID != productid && x.CategoryID == product.CategoryID).ToList();
        }

    }
}
