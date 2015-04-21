using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_Views.Models
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }


        public bool OnSale { get; set; }
    }
}