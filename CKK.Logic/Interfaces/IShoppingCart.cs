using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
    public interface IShoppingCart
    {
        public abstract int GetCustomerId();

        public abstract ShoppingCartItem AddProduct(Product prod, int quant);

        public abstract ShoppingCartItem RemoveProduct(int id, int quant);

        public abstract decimal GetTotal();

        public abstract ShoppingCartItem GetProductById(int id);

        public abstract List<ShoppingCartItem> GetProducts();
    }
}
