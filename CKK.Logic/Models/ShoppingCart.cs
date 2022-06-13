using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
    {
        public Customer Customer = new();
        public List<ShoppingCartItem> Products = new();

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
            if (quantity < 1)
            {
                throw new InventoryItemStockTooLowException();
            }
            for(int index = 0; index < Products.Count; index++)
            {
                if (Products[index].Product == prod)
                {
                    Products[index].SetQuantity(Products[index].Quantity + quantity);
                    return Products[index];
                }
            }
            ShoppingCartItem returnItem = new(prod, quantity);
            Products.Add(returnItem);
            return returnItem;
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
            }
            ShoppingCartItem returnItem = new(prod, 1);
            Products.Add(returnItem);
            return returnItem;
        }
        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            ShoppingCartItem returnItem = new(null, 0);
                for (int index = 0; index < Products.Count; index++)
                {
                    if (Products[index].Product.Id == id)
                    {
                        Products[index].SetQuantity(Products[index].Quantity - quantity);
                        if (Products[index].Quantity <= 0)
                        {
                            returnItem = Products[index];
                            returnItem.SetQuantity(0);
                            Products.RemoveAt(index);
                            return returnItem;
                        }
                        else
                        {
                            return Products[index];
                        }
                    }
                }
                throw new ProductDoesNotExistException();
        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException();
            }
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
