using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class StoreItem
    {   
        public int Quantity;
        public Product Product;
        public StoreItem(Product _product, int _quantity)
        {
            Quantity = _quantity;
            Product = _product;
        }
        

        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int ItemQuant)
        {
            Quantity = ItemQuant;
        }

        public Product GetProduct()
        {
            return Product;
        }

        public void SetProduct(Product _product)
        {
            Product = _product;
        }
    }
}
