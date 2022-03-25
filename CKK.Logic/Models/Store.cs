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
        private Product Product1;
        private Product Product2;
        private Product Product3;

        //Defining "Store" methods
        public int GetId()
        {
            return Id;
        }

        public void SetId(int StoreID)
        {
            Id = StoreID;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string StoreName)
        {
            Name = StoreName;
        }

        public void AddStoreItem(Product prod)
        {
            if (Product1 == null)
            {
                Product1 = prod;
            }
            else if (Product2 == null)
            {
                Product2 = prod;
            }
            else if (Product3 == null)
            {
                Product3 = prod;
            }
            else
            {
                Console.WriteLine("ERROR: No open product slots");
            }
        }

        public void RemoveStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                if (Product1 == null)
                {
                    Console.WriteLine("No Store Item found in position 1");
                }
                else
                {
                    Console.WriteLine($"{Product1.Name} deleted from position 1");
                    Product1 = null;
                }
            }
            else if (productNumber == 2)
            {
                if (Product2 == null)
                {
                    Console.WriteLine("No Store Item found in position 2");
                }
                else
                {
                    Console.WriteLine($"{Product2.Name} deleted from position 2");
                    Product2 = null;
                }
            }
            else if (productNumber == 3)
            {
                if (Product3 == null)
                {
                    Console.WriteLine("No Store Item found in position 3");
                }
                else
                {
                    Console.WriteLine($"{Product3.Name} deleted from position 3");
                    Product3 = null;
                }
            }

            else
            {
                Console.WriteLine("Item position does not exist");
            }
        }

        public Product GetStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                if(Product1 == null)
                {
                    Console.WriteLine("No Store Item found in position 1");
                    return null;
                }
                else
                {
                    return Product1;
                }
            }
            else if (productNumber == 2)
            {
                if (Product2 == null)
                {
                    Console.WriteLine("No Store Item found in position 2");
                    return null;
                }
                else
                {
                    return Product2;
                }
            }
            else if (productNumber == 3)
            {
                if (Product3 == null)
                {
                    Console.WriteLine("No Store Item found in position 3");
                    return null;
                }
                else
                {
                    return Product3;
                }
            }
            else
            {
                Console.WriteLine("Item position does not exist");
                return null;
            }
        }

        public Product FindStoreItemById(int id)
        {
            if (id == Product1.Id)
            {
                return Product1;
            }
            else if (id == Product2.Id)
            {
                return Product2;
            }
            else if (id == Product3.Id)
            {
                return Product3;
            }
            else
            {
                Console.WriteLine("No store object found");
                return null;
            }
        }
    }
}
