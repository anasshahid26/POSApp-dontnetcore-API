using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSApp.API.Models
{
    public class Items
    {
        public int id { get; set; }

        public string name { get; set; }
        public string category { get; set; }

        public int supplier_id { get; set; }

        public string item_number { get; set; }
        public string product_id { get; set; }
        public string description { get; set; }

        public int tax_included { get; set; }

        public float cost_price { get; set; }
        public float unit_price { get; set; }
        public float promo_price { get; set; }

        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }

        public decimal reorder_level { get; set; }

        public int item_id { get; set; }

        public int allow_alt_description { get; set; }
        public int is_serialized { get; set; }

        public int image_id { get; set; }

        public int override_default_tax { get; set; }
        public int is_service { get; set; }
        public int deleted { get; set; }



    }
}
