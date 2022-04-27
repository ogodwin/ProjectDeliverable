using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        public Customer Customer = new Customer();
        public List<ShoppingCartItem> Products = new List<ShoppingCartItem>();

        public ShoppingCart(Customer _customer)
        {
            Customer = _customer;
        }

        public int GetCustomerId()
        {
            return Customer.Id;
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            for(int index = 0; index < Products.Count; index++)
            {
                if (Products[index].Product == prod)
                {
                    Products[index].SetQuantity(Products[index].Quantity + quantity);
                    return Products[index];
                }
                else
                {
                    Products.Add(new ShoppingCartItem(prod, quantity));
                    return new ShoppingCartItem(prod, quantity);
                }
            }
            return null;
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            for (int index = 0; index < Products.Count; index++)
            {
                if (Products[index].Product == prod)
                {
                    Products[index].SetQuantity(Products[index].Quantity + 1);
                    return Products[index];
                }
                else
                {
                    Products.Add(new ShoppingCartItem(prod, 1));
                    return new ShoppingCartItem(prod, 1);
                }
            }
            return null;
        }
        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            ShoppingCartItem returnItem = new ShoppingCartItem(null, 0);
            for (int index = 0; index < Products.Count; index++)
            {
                if (Products[index].Product.Id == id)
                {
                    Products[index].SetQuantity(Products[index].Quantity - quantity);
                    if(Products[index].Quantity <= 0)
                    {
                        returnItem = Products[index];
                        Products.RemoveAt(index);
                        return returnItem;
                    }
                    else
                    {
                        return Products[index];
                    }
                }
                Console.WriteLine("No Product Found");
            }
            return returnItem;
        }

        public ShoppingCartItem GetProductById(int id)
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

        public decimal GetTotal()
        {
            decimal total = 0; 
            for (int index = 0; index < Products.Count; index++)
            {
                total += Products[index].Product.Price * Products[index].Quantity;
            }
            return total;
        }

        public List<ShoppingCartItem> GetProducts()
        {
            return Products;
        }
    }
}
