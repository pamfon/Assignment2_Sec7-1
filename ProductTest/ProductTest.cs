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
		//this test was created to check if the minimum product Id could be entered and returned successfully
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
		//this test was created to check if the maximum product Id could be entered and returned successfully
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
		//this test was created to check if the median product Id could be entered and returned successfully
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
		//this test was created to check if the minimum price could be entered and returned successfully
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
		//this test was created to check if the maximum price could be entered and returned successfully
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
		//this test was created to check if the median price could be entered and returned successfully
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

		#region StocksTests
		[Test]
		//this test was created to check if the minimum stock could be entered and returned successfully
		public void InputForStock_Input7_Outuput7()
		{
			// Arrange
			int productID = 7;
			string productName = "Laptop";
			double price = 7.00;
			int stock = 7;

			// Act
			Product product = new Product(productID, productName, price, stock);
			int actual = product.Stock;
			int expected = 7;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		//this test was created to check if the maximum stock could be entered and returned successfully
		public void InputForStock_Input700000_Outuput700000()
		{
			// Arrange
			int productID = 7;
			string productName = "Laptop";
			double price = 7.00;
			int stock = 700000;

			// Act
			Product product = new Product(productID, productName, price, stock);
			int actual = product.Stock;
			int expected = 700000;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		//this test was created to check if the median stock could be entered and returned successfully
		public void InputForStock_Input349997_Outuput349997()
		{
			// Arrange
			int productID = 7;
			string productName = "Laptop";
			double price = 7;
			int stock = 349997;

			// Act
			Product product = new Product(productID, productName, price, stock);
			int actual = product.Stock;
			int expected = 349997;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		#endregion

		#region RangeTests
		[Test]
		//this test was created to check if a product Id that was inputted within the minimum and maximum range, would return true when using an "is in range" method
		public void InputRangeForProductId_Input10_OutuputTrue()
		{
			// Arrange
			int productID = 10;
			string productName = "Laptop";
			double price = 7.00;
			int stock = 7;

			// Act
			Product product = new Product(productID, productName, price, stock);
			bool actual = product.IsProductIdInRange();
			bool expected = true;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		//this test was created to check if a price that was inputted within the minimum and maximum range, would return true when using an "is in range" method
		public void InputRangeForPrice_Input10_OutuputTrue()
		{
			// Arrange
			int productID = 7;
			string productName = "Laptop";
			double price = 10;
			int stock = 7;

			// Act
			Product product = new Product(productID, productName, price, stock);
			bool actual = product.IsPriceInRange();
			bool expected = true;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		//this test was created to check if a stock that was inputted within the minimum and maximum range, would return true when using an "is in range" method
		public void InputRangeForStock_Input10_OutuputTrue()
		{
			// Arrange
			int productID = 7;
			string productName = "Laptop";
			double price = 7;
			int stock = 10;

			// Act
			Product product = new Product(productID, productName, price, stock);
			bool actual = product.IsStockInRange();
			bool expected = true;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		#endregion

		#region StockManipulationTest
		[Test]
		//this test was created to check if the inputted value for stock to be incremented by is valid, in which it will return true
		public void ValidStockIncrease_Input1_OutputTrue()
		{
			// Arrange
			int ProductID = 7;
			string ProductName = "product";
			double Price = 7;
			int Stock = 7;

			// Act
			Product product = new Product(ProductID, ProductName, Price, Stock);
			bool actual = product.IncreaseStock(1);
			bool expected = true;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		//this test was created to check if the inputted value for stock to be incremented by is invalid, in which it will return false
		public void InvalidStockIncrease_Input_Neg1_OutputFalse()
		{
			// Arrange
			int ProductID = 7;
			string ProductName = "product";
			double Price = 7;
			int Stock = 7;

			// Act
			Product product = new Product(ProductID, ProductName, Price, Stock);
			bool actual = product.IncreaseStock(-1);
			bool expected = false;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		//this test was created to check if the inputted value for stock to be decreased by is valid, in which it will return true
		public void ValidStockDecrease_Input1_OutputTrue()
		{
			// Arrange
			int ProductID = 7;
			string ProductName = "product";
			double Price = 7;
			int Stock = 8;

			// Act
			Product product = new Product(ProductID, ProductName, Price, Stock);
			bool actual = product.DecreaseStock(1);
			bool expected = true;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		//this test was created to check if the inputted value for stock to be decreased by is invalid, in which it will return false
		public void InvalidStockDecrease_Input_Neg1_OutputFalse()
		{
			// Arrange
			int ProductID = 7;
			string ProductName = "product";
			double Price = 7;
			int Stock = 7;

			// Act
			Product product = new Product(ProductID, ProductName, Price, Stock);
			bool actual = product.DecreaseStock(-1);
			bool expected = false;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}
		#endregion

		#region ProductNameValidation
		[Test]
		//this test was created to check if the inputted value for product name is valid, in which it will return true
		public void ValidProductNameValidation_InputProductName_OutputTrue()
		{
			// Arrange
			int ProductID = 7;
			string ProductName = "product";
			double Price = 7;
			int Stock = 7;

			// Act
			Product product = new Product(ProductID, ProductName, Price, Stock);
			bool actual = product.ProductNameValidation(ProductName);
			bool expected = true;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		//this test was created to check if the inputted value for product name is invalid, in which it will return false
		public void InvalidProductNameValidation_Input__OutputTrue()
		{
			// Arrange
			int ProductID = 7;
			string ProductName = " ";
			double Price = 7;
			int Stock = 7;

			// Act
			Product product = new Product(ProductID, ProductName, Price, Stock);
			bool actual = product.ProductNameValidation(ProductName);
			bool expected = false;

			// Assert
			Assert.That(actual, Is.EqualTo(expected));
		}
		#endregion
	}
}

