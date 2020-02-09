using slnProducts.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace slnProducts.Controllers
{
    public class ProductFrontController : Controller
    {
        dbShoppingForumEntities db = new dbShoppingForumEntities();
        // GET: ProductFront

        public ActionResult ProductPage()
        {
            return View();
        }//gagagaag123
        // 嗚嘎嘎帥
    }
}