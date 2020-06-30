using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    public class Ebook : Product
    {
        private int duration;
        //private int productId;
        public Ebook()
        { }

        public Ebook(int id, string productName, double currentPrice, string productDescription, int duration) : base(productName, currentPrice, productDescription)
        {
            //NumberOfProducts += 1;
            this.productId = id;
            this.productName = productName;
            this.productDescription = productDescription;
            this.currentPrice = currentPrice;
            this.duration = duration;
            if (NumberOfProducts < this.productId)
            {
                NumberOfProducts += 1;
            }
        }

        public override string Value() => this.duration.ToString();
        public override string Info() => $"Tytuł: {productName}\nTyp: Ebook\nCzas trwania: {duration}min\nCena: {currentPrice}\n\nOpis:\n{ProductDescription}";
    }
}
