using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    class Book : Product
    {
        private int liczbaStron;
        //private int productId;
        public Book()
        { }

        public Book(string productName, double currentPrice, string productDescription, int liczbaStron) : base( productName,  currentPrice,  productDescription)
        {
            NumberOfProducts += 1;
            productId = NumberOfProducts;
            this.productName = productName;
            this.productDescription = productDescription;
            this.currentPrice = currentPrice;
            this.liczbaStron = liczbaStron;
        }


        // public new int ProductId
        // {
        //     get { return productId; }
        //     set { productId = value; }
        // }

        public override string Info() => $"Tytuł: {productName}\nTyp: książka\nIlość stron: {liczbaStron}\nCena: {currentPrice}\n\nOpis:\n{ProductDescription}";
    }
}
