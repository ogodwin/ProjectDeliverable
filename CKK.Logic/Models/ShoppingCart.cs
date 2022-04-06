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
        public ShoppingCartItem Product1 = null;
        public ShoppingCartItem Product2 = null;
        public ShoppingCartItem Product3 = null;

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
            Console.WriteLine(prod.Id);
            Console.WriteLine(prod.Name);
            Console.WriteLine(prod.Price);
            if (prod != null){
                

            if (Product1 == null)
            {
                Product1 = new ShoppingCartItem(prod, quantity);
                return Product1;
            }
                
            else if (Product1.Product == prod) 
            {
                Product1.Quantity += quantity;
                return Product1;
            }

            else if (Product2 == null)
            {
                Product2 = new ShoppingCartItem(prod, quantity);
                return Product2;
            }
                
            else if (Product2.Product == prod) 
            {
                Product2.Quantity += quantity;
                return Product2;
            }

            else if (Product3 == null)
            {
                Product3 = new ShoppingCartItem(prod, quantity);
                return Product3;
            }
                
            else if (Product3.Product == prod) 
            {
                Product3.Quantity += quantity;
                return Product3;
            }

            else
            {
                Console.WriteLine("Shopping cart is full!");
                return null;
            }}
            else {return null;}
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            Console.WriteLine(prod.Id);
            Console.WriteLine(prod.Name);
            Console.WriteLine(prod.Price);
            if (prod != null)
            {
               
            
            if (Product1 == null)
            {
                Product1 = new ShoppingCartItem(prod, 1);
                return Product1;
            }
            
            else if (Product1.Product == prod) 
            {
                Product1.Quantity++;
                return Product1;
            }


            else if (Product2 == null)
            {
                Product2 = new ShoppingCartItem(prod, 1);
                return Product2;
            }

            else if (Product2.Product == prod) 
            {
                Product2.Quantity++;
                return Product2;
            }
                
            else if (Product3 == null)
            {
                Product3 = new ShoppingCartItem(prod, 1);
                return Product3;
            }
                
            else if (Product3.Product == prod) 
            {
                Product3.Quantity++;
                return Product3;
            }

            else
            {
                Console.WriteLine("Shopping cart is full!");
                return null;
            }
            }
            else {
                return null;
            }
        }

        public ShoppingCartItem RemoveProduct(Product prod, int quant)
        {
            if (prod == Product1.Product)
            {
                if (Product1.Quantity > quant)
                {
                    Product1.Quantity -= quant;
                    return Product1;
                }

                else if (Product1.Quantity <= quant)
                {
                    ShoppingCartItem exProduct = Product1;
                    Product1 = null;
                    return exProduct;
                }
                else
                {
                    return null;
                }
            }

            else if (prod == Product2.Product)
            {
                if (Product2.Quantity > quant)
                {
                    Product2.Quantity -= quant;
                    return Product2;
                }

                else if(Product2.Quantity <= quant)
                {
                    ShoppingCartItem exProduct = Product2;
                    Product2 = null;
                    return exProduct;
                }
                else
                {
                    return null;
                }
            }

            else if (prod == Product3.Product)
            {
                if (Product3.Quantity > quant)
                {
                    Product3.Quantity -= quant;
                    return Product3;
                }

                else if(Product3.Quantity <= quant)
                {
                    ShoppingCartItem exProduct = Product3;
                    Product3 = null;
                    return exProduct;
                }
                else
                {
                    return null;
                }
            }

            else
            {
                Console.WriteLine("Product not found");
                return null;
            }
        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (Product1.Product.Id == id)
            {
                return Product1;
            }

            else if (Product2.Product.Id == id)
            {
                return Product2;
            }

            else if (Product3.Product.Id == id)
            {
                return Product3;
            }

            else
            {
                Console.WriteLine("Product not found");
                return null;
            }
        }

        public decimal GetTotal()
        {
            return (Product1.GetTotal() + Product2.GetTotal() + Product3.GetTotal());
        }

        public ShoppingCartItem GetProduct(int num)
        {
            if(num == 1)
            {
                if (Product1 != null)
                {
                    return Product1;
                }

                else
                {
                    Console.WriteLine("No item in position 1");
                    return Product1;
                }
            }

            else if (num == 2)
            {
                if (Product2 != null)
                {
                    return Product2;
                }

                else
                {
                    Console.WriteLine("No item in position 2");
                    return Product2;
                }
            }

            else if (num == 3)
            {
                if (Product3 != null)
                {
                    return Product3;
                }

                else
                {
                    Console.WriteLine("No item in position 3");
                    return Product3;
                }
            }
            else
            {
                Console.WriteLine("Invalid entry");
                return null;
            }
        }
    }
}
