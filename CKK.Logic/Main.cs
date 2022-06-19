using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic
{
    class Program
    {
        public static void Main()
        {
            Store store = new Store();
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Book";
            product1.Price = 10;
            store.AddStoreItem(product1, 9);
            Console.WriteLine($"Added {store.Items[0].Quantity} books");
            store.RemoveStoreItem(1, 9);
            //store.RemoveStoreItem(1, 10);
            Console.WriteLine(store.Items[0].Product.Name);

            Customer customer = new Customer();
            ShoppingCart cart = new ShoppingCart(customer);
            cart.AddProduct(product1);
            Console.WriteLine($"Added {cart.Products[0].Product.Name}");
            cart.RemoveProduct(1, 1);
            //cart.RemoveProduct(1, 2);
            Console.WriteLine(cart.Products[0].Quantity);
            
        }
    }
}
