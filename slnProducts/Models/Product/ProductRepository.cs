using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using slnProducts.Models.Entity;

namespace slnProducts.Models.Product
{
    public class ProductRepository
    {
        dbShoppingForumEntities db = new dbShoppingForumEntities();

        public IQueryable<tProduct> SearchProducts(string searchprod, int? categoryId, int? efficacyId, int? noteId, int? partId, int? featureId)
        {
            var products = db.tProduct.AsQueryable();

            //搜尋商品名稱(糢糊搜尋)
            if (searchprod != null)
            {
                products = products.Where(p => p.fProductChName.Contains(searchprod));
            }

            //找全部商品類別
            if (categoryId != null)
            {
                products = products.Where(p => p.fCategoryID == categoryId);
            }
            //找全部商品功效
            if (efficacyId != null)
            {
                products = products.Where(p => p.tEfficacy.Any(q => q.fEfficacyID == efficacyId));
            }
            //找單方精油香調
            if (noteId != null)
            {
                products = products.Where(p => p.tProductUnilateral != null &&
                p.tProductUnilateral.fNoteID == noteId);
            }
            //找單方精油萃取部位
            if (partId != null)
            {
                products = products.Where(p => p.tProductUnilateral != null &&
                p.tProductUnilateral.fPartID == partId);
            }
            //找植物油&純露特性
            if (featureId != null)
            {
                products = products.Where(p => p.tProductVegetableoil != null &&
                  p.tProductVegetableoil.ffeatureID == featureId);
            }

            return products;
        }
    }
}