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

        public void IncreaseStock(int quantityToIncrease)
        {
            Stock = Stock + quantityToIncrease;
        }

        public void DecreaseStock(int quantityToDecrease)
        {
            Stock = Stock - quantityToDecrease;
        }
    }
}
