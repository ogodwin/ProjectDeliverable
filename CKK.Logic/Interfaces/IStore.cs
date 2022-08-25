using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Interfaces;
using System.ComponentModel;

namespace CKK.Logic.Interfaces
{
    public interface IStore
    {
        public abstract StoreItem AddStoreItem(Product prod, int quantity);

        public abstract StoreItem RemoveStoreItem(int id, int quantity);

        public abstract StoreItem FindStoreItemById(int id);

        public abstract List<StoreItem> GetStoreItems();

        public abstract StoreItem DeleteStoreItem(int id);

        public abstract BindingList<StoreItem> GetAllProductsByName(string name, BindingList<StoreItem> store);

        public abstract BindingList<StoreItem> GetProductsByQuantity(BindingList<StoreItem> store);

        public abstract BindingList<StoreItem> GetProductsByPrice(BindingList<StoreItem> store);
    }
}
