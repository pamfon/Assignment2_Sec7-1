using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2_Sec7_1
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(int productID, string productName, double price, int stock)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

		public bool ProductNameValidation(string ProductName)
		{
			if (string.IsNullOrWhiteSpace(ProductName))
			{
				return false;
			}

			return true;
		}

		#region ChangeStock
		public bool IncreaseStock(int amount)
		{
			if (amount < 1)
			{
				return false;
			}

			Stock += amount;
			return true;
		}
		

		public bool DecreaseStock(int amount)
		{
			if (amount < 1 || Stock < 0)
			{
				return false;
			}

			Stock -= amount;
			return true;
		}
		#endregion

		#region InRangeTests
		public bool IsPriceInRange()
		{
			return Price >= 7 && Price <= 7000;
		}

		public bool IsProductIdInRange()
		{
			return ProductID >= 7 && ProductID <= 70000;
		}

		public bool IsStockInRange()
		{
			return Stock >= 7 && Stock <= 700000;
		}
		#endregion
	}
}
