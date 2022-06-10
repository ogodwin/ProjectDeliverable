using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store : CKK.Logic.Interfaces.Entity, CKK.Logic.Interfaces.IStore
    {
        //Instantiating "Store" attributes
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
                if (Items[index].GetProduct() == prod)
                {
                    Items[index].SetQuantity(Items[index].GetQuantity() + quantity);
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
                if (Items[index].GetProduct() == prod)
                {
                    Items[index].SetQuantity(Items[index].GetQuantity() + 1);
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
                if (Items[index].GetProduct().GetId() == id)
                {
                    Items[index].SetQuantity(Items[index].GetQuantity() - quant);
                    if (Items[index].GetQuantity() < 0)
                    {
                        Items[index].SetQuantity(0);
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

                if (Items[index].GetProduct().GetId() == id)
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
