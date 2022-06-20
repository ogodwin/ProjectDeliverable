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
        public List<StoreItem> Items = new();

        public Store()
        {

        }


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

            int index = Items.FindIndex(f => f.Product.Id == id);
            if (index == -1)
            {
                throw new ProductDoesNotExistException();
            }

            else
            {
                if (Items[index].Quantity - quant < 0)
                {
                    Items[index].Quantity = 0;
                }
                else
                {
                    Items[index].Quantity -= quant;
                }
                Console.WriteLine(Items[index].Quantity);
                return Items[index];
            }
        }

        public StoreItem FindStoreItemById(int id)
        {
            if (id < 0)throw new InvalidIdException();
            return Items.FirstOrDefault(f => f.Product.Id == id);
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }

    }
}
