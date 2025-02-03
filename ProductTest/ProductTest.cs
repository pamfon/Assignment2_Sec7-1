using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2_Sec7_1;

namespace ProductTest
{
    
    [TestFixture]
    public class Tests
    {
        #region ProductIDTests
        [Test]

        public void InputForProductID_Input7_Outuput7()
        {
            // Arrange
            int productID = 7;
            string productName = "Laptop";
            double price = 22.30;
            int stock = 10;
            
            // Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;
            int expected = 7;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void InputForProductID_Input70000_Outuput70000()
        {
            // Arrange
            int productID = 70000;
            string productName = "Laptop";
            double price = 22.30;
            int stock = 10;

            // Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;
            int expected = 70000;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void InputForProductID_Input34997_Outuput34997()
        {
            // Arrange
            int productID = 34997;
            string productName = "Laptop";
            double price = 22.30;
            int stock = 10;

            // Act
            Product product = new Product(productID, productName, price, stock);
            int actual = product.ProductID;
            int expected = 34997;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        #endregion

        #region PriceTests
        [Test]
        public void InputForPrice_Input7_Outuput7()
        {
            // Arrange
            int productID = 7;
            string productName = "Laptop";
            double price = 7.00;
            int stock = 10;

            // Act
            Product product = new Product(productID, productName, price, stock);
            double actual = product.Price;
            double expected = 7.00;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void InputForPrice_Input7000_Outuput7000()
        {
            // Arrange
            int productID = 7;
            string productName = "Laptop";
            double price = 7000.00;
            int stock = 10;

            // Act
            Product product = new Product(productID, productName, price, stock);
            double actual = product.Price;
            double expected = 7000.00;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void InputForPrice_Input3496_5_Outuput3496_5()
        {
            // Arrange
            int productID = 7;
            string productName = "Laptop";
            double price = 3496.50;
            int stock = 10;

            // Act
            Product product = new Product(productID, productName, price, stock);
            double actual = product.Price;
            double expected = 3496.50;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        #endregion

        #region StockTests


        #endregion
    }
}

