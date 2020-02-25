using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Business.Models
{
    public class Product
    {
        public string ArticleId { get; set;  }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {

        }

        public Product(string ArticleId, string Name, decimal Price)
        {
            this.ArticleId = ArticleId;
            this.Name = Name;
            this.Price = Price;
        }
    }
}
