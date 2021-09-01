using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.ViewModels
{
    public class CostVM
    {
        public string plant { get; set; }

        public string item_spec { get; set; }

        public string issue_date { get; set; }

        public string section { get; set; }

        public string doc_no { get; set; }

        public string wr_no { get; set; }

        public string sales { get; set; }

        public string revision_no { get; set; }

        public string checked_date { get; set; }

        public string approved_by { get; set; }

        public string customer { get; set; }

        public string parts_code { get; set; }

        public string item { get; set; }

        public string product { get; set; }

        public string product_type { get; set; }

        public string size { get; set; }

        public string business_type { get; set; }

        public int qty_month { get; set; }

        public double exchange_rate { get; set; }

        public double target_price_bht { get; set; }

        public double target_price_export { get; set; }
        public double production_qty_day { get; set; }
        public double working_day { get; set; }
    }
}
