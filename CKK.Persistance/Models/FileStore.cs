using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Persistance.Interfaces;

namespace CKK.Persistance.Models
{
    class FileStore : IStore, ISavable, ILoadable
    {
        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            return null;
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            return null;
        }

        public StoreItem FindStoreItemById(int id)
        {
            return null;
        }

        public List<StoreItem> GetStoreItems()
        {
            return null;
        }

        public StoreItem DeleteStoreItem(int id)
        {
            return null;
        }
    }
}
