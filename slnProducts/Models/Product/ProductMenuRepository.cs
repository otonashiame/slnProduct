using slnProducts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using slnProducts.Models.Entity;

namespace slnProducts.Models.Product
{
    public class ProductMenuRepository
    {
        dbShoppingForumEntities db = new dbShoppingForumEntities();

        public ProductMenu GetProductMenu()
        {
            var productMenu = new ProductMenu();
            productMenu.CategoryList = db.tCategory.ToList();
            productMenu.EfficacyList = db.tEfficacy.ToList();
            productMenu.PartList = db.tPart.ToList();
            productMenu.NoteList = db.tNote.ToList();
            productMenu.FeatureList = db.tfeature.ToList();
            return productMenu;
        }

    }
}