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
        public Product product;
        public StoreItem(Product _product, int _quantity)
        {
            Quantity = _quantity;
            product = _product;
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
            return product;
        }

        public void SetProduct(int productid, string productname, float productprice)
        {
            product.Id = productid;
            product.Name = productname;
            product.Price = productprice;
        }
    }
}
