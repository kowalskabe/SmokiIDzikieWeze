using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    class Product
    {
        private int productId;
        private decimal currentPrice;
        private string productName;
        private string productDescription;


        Product() 
        { 
        }

        Product(int productId)
        {
            ProductId = productId;
        }


        public int ProductId
        {
            get { return productId; }
            private set { productId = value; }
        }

        public decimal? CurrentPrice { get; set; }

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
    }
}
