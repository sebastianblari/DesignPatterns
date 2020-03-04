using ShoppingCart.Business.Models;
using System.Collections.Generic;

namespace ShoppingCart.Business.Repositories
{
    public interface IShoppingCartRepository
    {
        (Product Product, int Quantity) Get(string articleId);
        IEnumerable<(Product Product, int Quantity)> All();
        void Add(Product product);
        void RemoveAll(string articleId);
        void IncreaseQuantity(string articleId);
        void DecreaseQuantity(string articleId);
    }
}