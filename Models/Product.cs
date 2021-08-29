using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlipCart.Models
{
    public class Product
    {
        //DB Class
        public int productId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; } 
    }
}