using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    [Serializable]
    public class ShoppingCartItem : InventoryItem
    {

        public ShoppingCartItem(Product _product, int _quantity)
        {
            Quantity = _quantity;
            Product = _product;
        }

        public decimal GetTotal()
        {
            return Quantity * Product.Price;
        }
    }
}
