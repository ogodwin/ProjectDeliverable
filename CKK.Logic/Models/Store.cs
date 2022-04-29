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

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity < 1)
            {
                return null;
            }
            for (int index = 0; index < Items.Count; index++)
            {
                if (Items[index].Product == prod)
                {
                    Items[index].SetQuantity(Items[index].Quantity + quantity);
                    return Items[index];
                }
            }
            StoreItem returnItem = new StoreItem(prod, quantity);
            Items.Add(returnItem);
            return returnItem;
        }
        public StoreItem AddStoreItem(Product prod)
        {
            for (int index = 0; index < Items.Count; index++)
            {
                if (Items[index].Product == prod)
                {
                    Items[index].SetQuantity(Items[index].Quantity + 1);
                    return Items[index];
                }
            }
            StoreItem returnItem = new StoreItem(prod, 1);
            Items.Add(returnItem);
            return returnItem;
        }

        public StoreItem RemoveStoreItem(int id, int quant)
        {
            for (int index = 0; index < Items.Count; index++)
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

            for (int index = 0; index < Items.Count; index++)
            {

                if (Items[index].Product.Id == id)
                {
                    return Items[index];
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
