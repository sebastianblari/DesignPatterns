using ShoppingCart.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Business.Repositories
{
    public class ProductsRepository : IProductRepository
    {
        private Dictionary<string, (Product Product, int Stock)> Products { get; } = new Dictionary<string, (Product Product, int Stock)>();

        public ProductsRepository()
        {
            Add(new Product("EOSR1", "Canon EOS R", 1099), 2);
            Add(new Product("EOS70D", "Canon EOS 70D", 699), 1);
            Add(new Product("ATOMOSNV", "Atomos Ninja V", 799), 0);
            Add(new Product("SM7B", "Shure SM7B", 399), 5);
        }

        public void Add(Product product, int stock)
        {
            Products.Add(product.ArticleId, (product, stock));
            //Products[product.ArticleId] = (product, stock);
        }

        public void DecreaseStockBy(string articleId, int amount)
        {
            if (!Products.ContainsKey(articleId))
            {
                return;
            }
            if (Products[articleId].Stock < amount)
            {
                return;
            }
            Products[articleId] = (Products[articleId].Product, Products[articleId].Stock - amount);
        }

        public void IncreaseStockBy(string articleId, int amount)
        {
            if (!Products.ContainsKey(articleId))
            {
                return;
            }
            Products[articleId] = (Products[articleId].Product, Products[articleId].Stock + amount);
        }

        public IEnumerable<Product> All()
        {
            return Products.Select(x => x.Value.Product);
        }
        public int GetStockFor(string articleId)
        {
            if (Products.ContainsKey(articleId))
            {
                return Products[articleId].Stock;
            }
            return 0;
        }
        public Product FindBy(string articleId)
        {
            if (Products.ContainsKey(articleId))
            {
                return Products[articleId].Product;
            }
            return null;
        }
    }
}
