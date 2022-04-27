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
        private List<StoreItem> Products = new List<StoreItem>();

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
            for (int index = 0; index < Products.Count; index++)
            {
                if (Products[index].Product.Id == prod.Id)
                {
                    Products[index].Quantity += quant;
                    return Products[index];
                }
            }
            Products.Add(new StoreItem(prod, quant));
            return new StoreItem(prod, quant);
        }

        public StoreItem RemoveStoreItem(int productNumber, int quant)
        {
            Products[productNumber].Quantity -= quant;
            if (Products[productNumber].Quantity <= 0)
            {
                Products[productNumber].Quantity = 0;
            }
            return Products[productNumber];
        }

        public StoreItem FindStoreItemById(int id)
        {
            for (int index = 0; index < Products.Count; index++)
            {
                if (Products[index].Product.Id == id)
                {
                    return Products[index];
                }
            }
            return null;
        }

        public List<StoreItem> GetStoreItems()
        {
            return Products;
        }

    }
}
