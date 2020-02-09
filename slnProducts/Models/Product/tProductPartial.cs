﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace slnProducts.Models.Entity
{
    [MetadataType(typeof(tProductMetadata))]
    public partial class tProduct
    {
        public class tProductMetadata
        {
            [DisplayName("商品編號")]
            public int fProductID { get; set; }

            [DisplayName("品名")]
            [Required]
            public string fProductChName { get; set; }

            [DisplayName("介紹")]
            [Required]
            public string fProductDesc { get; set; }

            [DisplayName("單價")]
            [Required]
            public Nullable<int> fUnitPrice { get; set; }

            [DisplayName("容量(ml)")]
            [Required]
            public string fQuantityPerUnit { get; set; }

            [DisplayName("庫存")]
            public Nullable<int> fUnitsInStock { get; set; }

            [DisplayName("缺貨中")]
            public Nullable<bool> fDiscontinued { get; set; }

            [DisplayName("商品分類")]
            [Required]
            public int fCategoryID { get; set; }

        }
    }
}