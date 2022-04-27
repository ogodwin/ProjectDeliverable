using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        //Instantiating "Store" attributes
        private int Id;
        private string Name;
        private List<StoreItem> Products = new List<StoreItem>();

        //Defining "Store" methods
        public int GetId()
        {
            return Id;
        }

        public int SetId(int StoreID)
        {
            Id = StoreID;
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public string SetName(string StoreName)
        {
            Name = StoreName;
            return Name;
        }

        public StoreItem AddStoreItem(Product prod, int quant)
        {
            if (quant < 1)
            {
                return null;
            }
            for (int index = 0; index < Products.Count; index++)
            {
                if (Products[index].Product.Id == prod.Id)
                {
                    Products[index].Quantity += quant;
                    return Products[index];
                }
            }
            Products.Add(new StoreItem(prod, quant));
            return new StoreItem(prod, quant);
        }
        public StoreItem AddStoreItem(Product prod)
        {
            for (int index = 0; index < Products.Count; index++)
            {
                if (Products[index].Product.Id == prod.Id)
                {
                    Products[index].Quantity += 1;
                    return Products[index];
                }
            }
            Products.Add(new StoreItem(prod, 1));
            return new StoreItem(prod, 1);
        }

        public StoreItem RemoveStoreItem(int id, int quant)
        {
            for (int index = 0; index < Products.Count; index++)
            {
                if (Products[index].Product.Id == id)
                {
                    Products[index].Quantity -= quant;
                    if (Products[index].Quantity < 0)
                    {
                        Products[index].Quantity = 0;
                    }
                    return Products[index];
                }
            }
            return null;
        }

        public StoreItem FindStoreItemById(int id)
        {

            for (int index = 0; index < Products.Count; index++) //Iterates through all items in Products list
            {
                if (Products[index].Product.Id == id) //Checks to see if the Product ID matches the passed value
                {
                    return Products[index]; //Returns the Product of the same ID
                }
            }
            return null;
        }

        public List<StoreItem> GetStoreItems()
        {
            return Products;
        }

    }
}
