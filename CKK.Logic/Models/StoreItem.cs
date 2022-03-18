using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class StoreItem
    {   
        public Product Product = new Product();
        public int Quantity;

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

        public void SetProduct(int productid, string productname, float productprice)
        {
            Product.Id = productid;
            Product.Name = productname;
            Product.Price = productprice;
        }
    }
}
