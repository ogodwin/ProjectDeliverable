using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        public int Id;
        public string Name;
        public float Price;

        public int GetId()
        {
            return Id;
        }

        public void SetId(int productid)
        {
            Id = productid;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string productname)
        {
            Name = productname;
        }

        public float GetPrice()
        {
            return Price;
        }

        public void SetPrice(float productprice)
        {
            Price = productprice;
        }
    }
}
