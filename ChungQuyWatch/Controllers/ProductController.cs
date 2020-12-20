using KetNoiCSDL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChungQuyWatch.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detatil(long id)
        {
            var product = new ProductDao().ViewDetatil(id);
            ViewBag.ChiTietSanPham = new ChiTietProductDao().ViewChiTietProduct(id);
            ViewBag.Sanphamlienquan = new ProductDao().ListRelatedProduct(id);
            ViewBag.Category = new ProductCategoryDao().ViewDetail(product.CategoryID.Value); 
            return View(product);
        }
    }
}