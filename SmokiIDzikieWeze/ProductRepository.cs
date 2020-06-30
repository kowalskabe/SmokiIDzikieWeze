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
        Product product = new Book("Kółko się Pani urwało", 36.99, "Najpierw włamano się do jej mieszkania. Złodzieje nie tylko ukradli pieniądze, biżuterię czy cenne dokumenty, lecz również sprofanowali najcenniejszą pamiątkę po mężu – jego galowy mundur.Policja zabiera się do śledztwa jak pies do jeża, chociaż ślepy wpadłby na to, że wszystkie tropy prowadzą do sąsiada z góry, faceta bez nogi.Nie ma mowy, tego munduru mu nie przepuści.Postanawia policzyć się z nim sama. Okazuje się jednak, że facet bez nogi został zamordowany, a ona sama jest pierwszą podejrzaną.Nie pozostaje jej nic innego, jak chwycić rączkę wiernego wózka zakupowego i rozpocząć własne śledztwo.", 350);
        Product product2 = new Book("Totalna demolka. Dziennik cwaniaczka.", 35.99, "Kolejne przygody George’a Heffleya wzbogacą jego już i tak przepełniony niecodziennymi sytuacjami dziennik. Co tym razem wydarzyło się w życiu cwaniaczka?", 224);
        Product product3 = new Ebook("Kwestia ceny", 27.9, "Brawurowa, błyskotliwa, poruszająca i pełna akcji nowa powieść jednego z najpopularniejszych polskich pisarzy. Kwestia ceny to thriller przygodowy na nowe czasy.", 360);
        
     
           
        public Product Retrieve(int productId)
        {
            return product;
        }
        public List<Product> Retrieve()
        {  
            products.Add(product);
            products.Add(product2);
            products.Add(product3);
            return products;
        }

    }
}
