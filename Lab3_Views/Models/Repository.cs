using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_Views.Models
{
    public class Repository
    {
        /// <summary>
        /// Used for return some data for example - usually would be retrieving from a real source...
        /// </summary>
        /// <returns></returns>
        public IList<Product> ListProducts()
        {
            return new List<Product>
            {
       new Product {Name="Eggs", Price=2.33m},
         new Product {Name="Milk", Price=1.99m},
         new Product {Name="Cheese", Price=8.50m}
            };
        }
    }
}