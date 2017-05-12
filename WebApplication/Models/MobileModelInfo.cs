using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class MobileModelInfo
    {
        public int ModelId { get; set; }
        public int BrandId { get; set; }
        public string ModelName { get; set; }
        public float DealerPrice { get; set; }
        public float Mop { get; set; }
        public float Mrp { get; set; }
        public int StockInHand { get; set; }
    }
}