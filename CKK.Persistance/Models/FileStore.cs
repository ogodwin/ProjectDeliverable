using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;
using CKK.Persistance.Interfaces;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CKK.Persistance.Models
{
    [Serializable]
    public class FileStore : IStore, ISavable, ILoadable
    {
        public BindingList<StoreItem> Items = new BindingList<StoreItem>();
        readonly string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "Persistance" + Path.DirectorySeparatorChar + "StoreItems.dat";
        private int _idCounter;

        public int idcounter
        {
            get { return _idCounter; }
            set { _idCounter = value; }
        }

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity < 1)
            {
                throw new InventoryItemStockTooLowException();
            }
            if (prod.Id == 0)                                       //Checks if the product ID is 0
            {
                bool idFound = false;
                int i = 1;
                while (idFound == false)                             //Loops until an empty ID is found
                {
                    if (Items.SingleOrDefault(item => item.Product.Id == i) == null)
                    {
                        prod.Id = i;
                        idFound = true;
                    }
                    else
                    {
                        i++;
                    }

                }
            }
            for (int index = 0; index < Items.Count; index++)       //Searches through all items
            {
                if (Items[index].Product == prod)                   //Adds to exsisting item's quantity
                {
                    Items[index].Quantity += quantity;
                    return Items[index];
                }
            }
            StoreItem returnItem = new(prod, quantity);
            Items.Add(returnItem);
            return returnItem;
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

        public void Save()
        {
            using(FileStream fileStream = File.Open(FilePath, FileMode.Open))
            {
                fileStream.SetLength(0);
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    formatter.Serialize(fileStream, Items);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Error serializing: " + e);
                }
            }
        }

        public void Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using(FileStream fileStream = File.Open(FilePath, FileMode.Open))
                {
                   Items = (BindingList<StoreItem>)formatter.Deserialize(fileStream);
                }
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Error serializing: " + e);
            }
        }

        public void CreatePath()
        {
            if (File.Exists(FilePath) == true)
            {
                return;
            }

            else
            {
                File.Create(FilePath);
                return;
            }
        }
    }
}
