using System;
using Xunit;

namespace CKK.Logic.Models
{
    public class CKKTest
    {
        public ShoppingCart testCart = new ShoppingCart(null, null, null, null);
        //Requirement: The inputted object must appear in position 1
        [Fact]
        public void AddingProduct()
        {
            Product PTest1 = new Product();
            PTest1.Id = 34;
            PTest1.Name = "Test";
            PTest1.Price = 12;
            ShoppingCartItem cartItemTest = new ShoppingCartItem(PTest1, 1);
            testCart.AddProduct(PTest1);
            Assert.True((cartItemTest.Product.Id == testCart.Product1.Product.Id) && (cartItemTest.Product.Name == testCart.Product1.Product.Name) && (cartItemTest.Product.Price == testCart.Product1.Product.Price));
        }


        //Requirement: The inputted object most be removed from position 1
        [Fact]
        public void RemovingProduct()
        {
            Product PTest1 = new Product();
            PTest1.Id = 34;
            testCart.AddProduct(PTest1);
            testCart.RemoveProduct(PTest1, 1);
            Assert.True(testCart.Product1 == null);
        }


        //Requirement: The correct total price must be returned
        [Fact]
        public void GettingTotal()
        {
            Product PTest1 = new Product();
            PTest1.Price = 35;
            testCart.AddProduct(PTest1);
            testCart.AddProduct(PTest1);
            testCart.AddProduct(PTest1);
            Assert.Equal(105, testCart.GetTotal());
        }
    }
}
