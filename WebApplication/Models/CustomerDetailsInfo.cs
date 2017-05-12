using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class CustomerDetailsInfo
    {
        public int CustomerId { get; set; }
        public int CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
    }
}