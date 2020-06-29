using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace SmokiIDzikieWeze
{
    public class ProductRepository
    {
        
        private List<Product> products = new List<Product>();
        Product product = new Product("Kółko się Pani urwało", 36.99, "Najpierw włamano się do jej mieszkania. Złodzieje nie tylko ukradli pieniądze, biżuterię czy cenne dokumenty, lecz również sprofanowali najcenniejszą pamiątkę po mężu – jego galowy mundur.Policja zabiera się do śledztwa jak pies do jeża, chociaż ślepy wpadłby na to, że wszystkie tropy prowadzą do sąsiada z góry, faceta bez nogi.Nie ma mowy, tego munduru mu nie przepuści.Postanawia policzyć się z nim sama. Okazuje się jednak, że facet bez nogi został zamordowany, a ona sama jest pierwszą podejrzaną.Nie pozostaje jej nic innego, jak chwycić rączkę wiernego wózka zakupowego i rozpocząć własne śledztwo.");
        
     
           
        public Product Retrieve(int productId)
        {
            return product;
        }
        public List<Product> Retrieve()
        {  
            products.Add(product);
            return products;
        }

        public bool Save(string productName, double currentPrice, string productDescription)
        {
            //tmp
            return true;
        }
    }
}
