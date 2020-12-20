using ChungQuyWatch.Models;
using KetNoiCSDL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChungQuyWatch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // Run project nó sẽ chạy vào action Index này. Nhưng không s ID
        // Chỗ này bạn nên sửa lại cái ID có thể không truyền vào, bạn để mặc định = 1 chẳng hạn.
        public ActionResult Index(long? ID)
        {
            ViewBag.Slides = new SlideDao().ListAll();
            var productDao = new ProductDao();
            long IDparam = 1;
            if (ID == null)
            {
                // Nếu cái ID không được truyền vào sẽ lấy toàn bộ sản phẩm
                ViewBag.NewProducts = productDao.ListByChitiet(IDparam,10);
            }
            else
            {
                // Nếu cái ID được truyền vào thì lấy 1 sản phẩm có ID = ID mà bạn truyền vào
                IDparam = (long)ID;
                ViewBag.NewProducts = productDao.ListByChitiet(IDparam,10);
                
            }
            ViewBag.SellProducts = productDao.ListNewProduct(5);
            

            return View();
        }
        [ChildActionOnly]
        public ActionResult CommonTop()
        {
            var model = new CommonTopDao().ListGroupId(1);
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult MenuTop()
        {
            var model = new MenuTopDao().ListDMSP();
            return PartialView(model);
        }

        [ChildActionOnly]
        public PartialViewResult MenuTopRight()
        {
            var cart = Session[Common.CommonConstants.CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return PartialView(list);
        }
    }
}