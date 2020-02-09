using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace slnProducts.Models.Entity
{
    public class DropDownList
    {
        dbShoppingForumEntities db = new dbShoppingForumEntities();

        //下拉選單--商品分類
        public List<SelectListItem> GetCategoryDropList()
        {
            var selectListItems = new List<SelectListItem>();
            selectListItems.Add(new SelectListItem {Value=null,Text="請選擇" });
            var categorys= db.tCategory.Select(p => new SelectListItem
            {
                Text = p.fCategoryName,
                Value = p.fCategoryID.ToString()
            });

            selectListItems.AddRange(categorys);
            return selectListItems;
        }

        //下拉選單--單方精油萃取部位
        public List<SelectListItem> GetPartDropDownList()
        {
            var selectListItems = new List<SelectListItem>();
            selectListItems.Add(new SelectListItem { Value = null, Text = "請選擇" });

            var parts= db.tPart.Select(p => new SelectListItem
            {
                Value = p.fPartID.ToString(),
                Text = p.fPartName
            }).ToList();

            selectListItems.AddRange(parts);
            return selectListItems;
            
        }

        //下拉選單--單方精油香調
        public List<SelectListItem> GetNoteDropList()
        {
            var selectListItems = new List<SelectListItem>();
            selectListItems.Add(new SelectListItem { Value = null,Text="請選擇" });
            var notes= db.tNote.Select(p => new SelectListItem
            {
                Value = p.fNoteID.ToString(),
                Text = p.fNoteName,
            }).ToList();

            selectListItems.AddRange(notes);
            return selectListItems;
        }

        //下拉選單--單方&副方精油功效
        public IQueryable<SelectListItem> GetEfficacyDropLise()
        {
            return db.tEfficacy.Select(p => new SelectListItem
            {
                Value = p.fEfficacyID.ToString(),
                Text=p.fEfficacyName
            });
        }

        //下拉選單--純露/植物油特性
        public List<SelectListItem> GetfeatureDropList()
        {
            var selectListItems = new List<SelectListItem>();
            selectListItems.Add(new SelectListItem { Value=null,Text="請選擇"});

            var features= db.tfeature.Select(p => new SelectListItem
            {
                Value = p.ffeatureID.ToString(),
                Text = p.ffeatureName
            }).ToList();

            selectListItems.AddRange(features);
            return selectListItems;
        }

    }
}