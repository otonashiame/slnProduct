using slnProducts.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using slnProducts.ViewModel;

namespace slnProducts.Controllers
{
    public class ProductFrontController : Controller
    {
        dbShoppingForumEntities db = new dbShoppingForumEntities();
        DropDownList DropDownList = new DropDownList();
        int pagesize = 10;

        // 檢視全部商品
        public ActionResult ProductFrontPage(int page = 1)
        {
            int currentPage = page < 1 ? 1 : page;
            var products = db.tProduct.ToList();
            var pageresult = products.ToPagedList(currentPage, pagesize);

            var productMenu = new ProductMenu();
            productMenu.CategoryList = db.tCategory.ToList();
            productMenu.EfficacyList = db.tEfficacy.ToList();
            productMenu.PartList = db.tPart.ToList();
            productMenu.NoteList = db.tNote.ToList();
            productMenu.FeatureList = db.tfeature.ToList();
            ViewBag.productMenu = productMenu;
            return View(pageresult);
        }
 
        public ActionResult ProductSinglePage(int productId)
        {
            ViewBag.CategoryList = db.tCategory.ToList();
            var ProductSingle = db.tProduct.FirstOrDefault(p => p.fProductID == productId);
            return View(ProductSingle);
        }

    }
}