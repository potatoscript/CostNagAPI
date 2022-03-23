using CostNAGAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.ViewModels
{
    public class ToolingsVM
    {
        public int ToolingId { get; set; }
        public string description { get; set; }
        public string source { get; set; }
        public double qty { get; set; }
        public string unit { get; set; }
        public double price { get; set; }
        public double od { get; set; }
        public double od_max { get; set; }
        public string type { get; set; }

        public List<ToolingsVM> ListModel = new List<ToolingsVM>();

        ///<summary>
        /// Gets or sets Costs.
        ///</summary>
        public List<Tooling> CostData { get; set; }

        ///<summary>
        /// Gets or sets CurrentPageIndex.
        ///</summary>
        public int CurrentPageIndex { get; set; }

        ///<summary>
        /// Gets or sets PageCount.
        ///</summary>
        public int PageCount { get; set; }
    }
}
