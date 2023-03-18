﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.models
{
    public class Item
    {
        [Key()]
        public int item_id {  get; set; }
        public string? item_name { get; set; }
        public string? item_count { get; set; }
        public string? price_import { get; set; }

        public string? price_pay { get; set; }


        // invoice relationship
        public virtual Invoice? invoice { get; set; }

        
        // supplier relationship
        public  virtual Supplier? supplier { get; set; }

        // product relationship
        public int product_guarantee_id { set; get; }
        [ForeignKey("product_guarantee_id")]
        public virtual ProductGuarantee? productGuarantee { get; set; }
    }
}
