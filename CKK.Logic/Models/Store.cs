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

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity < 1)
            {
                throw new InventoryItemStockTooLowException();
            }
            for (int index = 0; index < Items.Count; index++)
            {
                if (Items[index].Product == prod)
                {
                    Items[index].Quantity += quantity;
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
                if (Items[index].Product == prod)
                {
                    Items[index].Quantity += 1;
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

            int itemInList = Items.FindIndex(f => f.Product.Id == id);
            if (itemInList == -1)
            {
                throw new ProductDoesNotExistException();
            }

            else
            {
                Items[itemInList].Quantity -= quant;
                if (Items[itemInList].Quantity < 0)
                {
                    Items[itemInList].Quantity = 0;
                }
                return Items[itemInList];
            }
        }

        public StoreItem FindStoreItemById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException();
            }

            int itemInList = Items.FindIndex(f => f.Product.Id == id);

            if (itemInList == -1)
            {
                return null;
            }

            else
            {
                return Items[itemInList];
            }
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }

    }
}
