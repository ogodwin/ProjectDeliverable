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
        private List<StoreItem> Items = new List<StoreItem>();

        public Store()
        {

        }

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
            for (int index = 0; index <= Items.Count; index++)
            {
                if (Items[index].Product.Id == prod.Id)
                {
                    Items[index].Quantity += quant;
                    return Items[index];
                }
            }
            Items.Add(new StoreItem(prod, quant));
            return new StoreItem(prod, quant);
        }
        public StoreItem AddStoreItem(Product prod)
        {
            for (int index = 0; index <= Items.Count; index++)
            {
                if (Items[index].Product.Id == prod.Id)
                {
                    Items[index].Quantity += 1;
                    return Items[index];
                }
            }
            Items.Add(new StoreItem(prod, 1));
            return new StoreItem(prod, 1);
        }

        public StoreItem RemoveStoreItem(int id, int quant)
        {
            for (int index = 0; index <= Items.Count; index++)
            {
                if (Items[index].Product.Id == id)
                {
                    Items[index].Quantity -= quant;
                    if (Items[index].Quantity < 0)
                    {
                        Items[index].Quantity = 0;
                    }
                    return Items[index];
                }
            }
            return null;
        }

        public StoreItem FindStoreItemById(int id)
        {

            for (int index = 0; index <= Items.Count; index++) //Iterates through all items in Products list
            {
                if (Items[index].Product.Id == id) //Checks to see if the Product ID matches the passed value
                {
                    Console.WriteLine("Found it");
                    return Items[index]; //Returns the Product of the same ID
                }
                else
                {
                    Console.WriteLine("Not this item");
                }
            }
            return null;
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }

    }
}
