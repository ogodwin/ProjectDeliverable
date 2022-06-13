using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class Store : Entity, IStore
    {
        //Instantiating "Store" attributes
        private List<StoreItem> Items = new();

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
                throw new InventoryItemStockTooLowException();
            }
            for (int index = 0; index < Items.Count; index++)
            {
                if (Items[index].GetProduct() == prod)
                {
                    Items[index].SetQuantity(Items[index].GetQuantity() + quantity);
                    return Items[index];
                }
            }
            StoreItem returnItem = new(prod, quantity);
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
            StoreItem returnItem = new(prod, 1);
            Items.Add(returnItem);
            return returnItem;
        }

        public StoreItem RemoveStoreItem(int id, int quant)
        {
            if (quant < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int index = 0; index < Items.Count; index++)
            {
                if (Items[index].GetProduct().Id == id)
                {
                    Items[index].SetQuantity(Items[index].GetQuantity() - quant);
                    if (Items[index].GetQuantity() < 0)
                    {
                        Items[index].SetQuantity(0);
                    }
                    return Items[index];
                }
            }
            throw new ProductDoesNotExistException();
        }

        public StoreItem FindStoreItemById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException();
            }

            for (int index = 0; index < Items.Count; index++)
            {

                if (Items[index].GetProduct().Id == id)
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
