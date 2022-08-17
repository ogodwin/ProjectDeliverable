﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
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
