using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    public class Product
    {
        private int productId;
        private double currentPrice;
        private string productName;
        private string productDescription;
        private static int NumberOfProducts = 0;

        public Product() 
        { 
        }

        public Product(string productName, double currentPrice, string productDescription)
        {
            NumberOfProducts += 1;
            ProductId = NumberOfProducts;
            this.productName = productName;
            this.productDescription = productDescription;
            this.currentPrice = currentPrice;
        }


        public int ProductId
        {
            get { return productId; }
            private set { productId = value; }
        }

        public double CurrentPrice 
        {
            get { return currentPrice; }
            set { currentPrice = value; } 
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public override string ToString()
        {
            return $"{ProductId}\t {ProductName}";
        }
    }
}
