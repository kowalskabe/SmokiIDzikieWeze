using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace SmokiIDzikieWeze
{
    public class ProductRepository : IProductRepository
    {
        
        private List<Product> productsRepository = new List<Product>();
        Product product = new Book(1,"Kółko się Pani urwało", 36.99, "Najpierw włamano się do jej mieszkania. Złodzieje nie tylko ukradli pieniądze, biżuterię czy cenne dokumenty, lecz również sprofanowali najcenniejszą pamiątkę po mężu – jego galowy mundur.Policja zabiera się do śledztwa jak pies do jeża, chociaż ślepy wpadłby na to, że wszystkie tropy prowadzą do sąsiada z góry, faceta bez nogi.Nie ma mowy, tego munduru mu nie przepuści.Postanawia policzyć się z nim sama. Okazuje się jednak, że facet bez nogi został zamordowany, a ona sama jest pierwszą podejrzaną.Nie pozostaje jej nic innego, jak chwycić rączkę wiernego wózka zakupowego i rozpocząć własne śledztwo.", 350);
       //Product product2 = new Book(2, "Totalna demolka. Dziennik cwaniaczka.", 35.99, "Kolejne przygody George’a Heffleya wzbogacą jego już i tak przepełniony niecodziennymi sytuacjami dziennik. Co tym razem wydarzyło się w życiu cwaniaczka?", 224);
       //Product product3 = new Ebook(3, "Kwestia ceny", 27.9, "Brawurowa, błyskotliwa, poruszająca i pełna akcji nowa powieść jednego z najpopularniejszych polskich pisarzy. Kwestia ceny to thriller przygodowy na nowe czasy.", 360);
       //Product product4 = new Ebook(4, "Pod kluczem", 27.9, "Diabolicznie zmyślna. Pokręcona i pełna zwrotów akcji. Trzymajcie w pogotowiu jakiś koc, będziecie mieć dreszcze", 300);
        
        String ResultText = String.Empty;
        private Product entity;
        public Product Entity
        {
            get { return entity; }
            set
            {
                entity = value;
            }
        }


        public List<Product> Add(Product newProduct, int type)
        {

            XElement doc = XElement.Load("Products.xml");
            IEnumerable<XElement> products =
                from product in doc.Elements("Product")
                select product;

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Encoding = Encoding.Unicode,
                Indent = true
            };

            //starting data
            using (XmlWriter writer = XmlWriter.Create("Products.xml", settings))
            {
                writer.WriteStartElement("Products");
                foreach (XElement product in products)
                {
                    writer.WriteStartElement("Product");

                    writer.WriteAttributeString("productId", product.Attribute("productId").Value);

                    writer.WriteStartElement("productType");
                    writer.WriteString(product.Element("productType").Value);
                    writer.WriteEndElement();

                    writer.WriteStartElement("productName");
                    writer.WriteString(product.Element("productName").Value);
                    writer.WriteEndElement();

                    writer.WriteStartElement("currentPrice");
                    writer.WriteString(product.Element("currentPrice").Value);
                    writer.WriteEndElement();
       

                    writer.WriteStartElement("description");
                    writer.WriteString(product.Element("description").Value);
                    writer.WriteEndElement();

                    writer.WriteStartElement("number");
                    writer.WriteString(product.Element("number").Value);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteStartElement("Product");

                writer.WriteAttributeString("productId", Product.NumberOfProducts.ToString());

                writer.WriteStartElement("productType");
                if (type == 0) writer.WriteString("Book");
                else writer.WriteString("Ebook");
                writer.WriteEndElement();

                writer.WriteStartElement("productName");
                writer.WriteString(newProduct.ProductName);
                writer.WriteEndElement();

                writer.WriteStartElement("currentPrice");
                writer.WriteString(newProduct.CurrentPrice.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("description");
                writer.WriteString(newProduct.productDescription);
                writer.WriteEndElement();

                writer.WriteStartElement("number");
                writer.WriteString(newProduct.Value());
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Close();

            }

            LoadXml("Products.xml");

            return Retrieve();
        }


        public List<Product> Delete(int i)
        {
            XDocument doc = XDocument.Load("Products.xml");

            XElement product =
                (from prod in doc.Descendants("Product")
                 where prod.Attribute("productId").Value == i.ToString()
                 select prod).SingleOrDefault();

            if (product != null)
            {
                product.Remove();
            }
            doc.Save("Products.xml");

            return Retrieve();
        }

        public Product Retrieve(int productId)
        {
            return product;
        }
        public List<Product> Retrieve()
        {
          // productsRepository.Add(product);
          // productsRepository.Add(product2);
          // productsRepository.Add(product3);
          // productsRepository.Add(product4);
            LoadXml("Products.xml");
            GetAll();
            return productsRepository;
        }

        private void GetAll()
        {
            StringBuilder sb = new StringBuilder(2048);
            XElement doc = XElement.Load("Products.xml");

            IEnumerable<XElement> products =
                from product in doc.Elements("Product")
                select product;

            foreach (XElement product in products)
            {
                sb.AppendLine(product.Element("productName").Value);
                int id = Int32.Parse(product.Attribute("productId").Value);
                if (  product.Element("productType").Value == "Book")
                {
                    var record = new Book(id, product.Element("productName").Value, Double.Parse(product.Element("currentPrice").Value), product.Element("description").Value, int.Parse(product.Element("number").Value));
                    productsRepository.Add(record);
                }
                else
                {
                    var record = new Ebook(id, product.Element("productName").Value, Double.Parse(product.Element("currentPrice").Value), product.Element("description").Value, int.Parse(product.Element("number").Value));
                    productsRepository.Add(record);
                }
                
            }
            ResultText = sb.ToString();
        }

        public List<Product> Update(Product editedCustomer)
        {
            throw new NotImplementedException();
        }

        private void LoadXml(string XmlFileName)
        {
            XDocument doc = new XDocument();

            if (!File.Exists(XmlFileName))
            {
                XmlWriterFormattingSave(XmlFileName);
            }
        }

        //data for start
        private void XmlWriterFormattingSave(string xmlFileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Encoding = Encoding.Unicode,
                Indent = true
            };

            //starting data
            using (XmlWriter writer = XmlWriter.Create(xmlFileName, settings))
            {
                writer.WriteStartElement("Products");
                writer.WriteStartElement("Product");

                writer.WriteAttributeString("productId", "1");

                writer.WriteStartElement("productType");
                writer.WriteString("Book");
                writer.WriteEndElement();

                writer.WriteStartElement("productName");
                writer.WriteString("Kółko się Pani urwało");
                writer.WriteEndElement();

                writer.WriteStartElement("currentPrice");
                writer.WriteString("36.99");
                writer.WriteEndElement();

                writer.WriteStartElement("number");
                writer.WriteString("350");
                writer.WriteEndElement();

                writer.WriteStartElement("description");
                writer.WriteString("Najpierw włamano się do jej mieszkania. Złodzieje nie tylko ukradli pieniądze, biżuterię czy cenne dokumenty, lecz również sprofanowali najcenniejszą pamiątkę po mężu – jego galowy mundur.Policja zabiera się do śledztwa jak pies do jeża, chociaż ślepy wpadłby na to, że wszystkie tropy prowadzą do sąsiada z góry, faceta bez nogi.Nie ma mowy, tego munduru mu nie przepuści.Postanawia policzyć się z nim sama. Okazuje się jednak, że facet bez nogi został zamordowany, a ona sama jest pierwszą podejrzaną.Nie pozostaje jej nic innego, jak chwycić rączkę wiernego wózka zakupowego i rozpocząć własne śledztwo.");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Product");

                writer.WriteAttributeString("productId", "2");

                writer.WriteStartElement("productType");
                writer.WriteString("Book");
                writer.WriteEndElement();

                writer.WriteStartElement("productName");
                writer.WriteString("Totalna demolka. Dziennik cwaniaczka.");
                writer.WriteEndElement();

                writer.WriteStartElement("currentPrice");
                writer.WriteString("35.99");
                writer.WriteEndElement();

                writer.WriteStartElement("number");
                writer.WriteString("240");
                writer.WriteEndElement();

                writer.WriteStartElement("description");
                writer.WriteString("Kolejne przygody George’a Heffleya wzbogacą jego już i tak przepełniony niecodziennymi sytuacjami dziennik. Co tym razem wydarzyło się w życiu cwaniaczka?");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Product");

                writer.WriteAttributeString("productId", "3");

                writer.WriteStartElement("productType");
                writer.WriteString("Ebook");
                writer.WriteEndElement();

                writer.WriteStartElement("productName");
                writer.WriteString("Kwestia ceny");
                writer.WriteEndElement();

                writer.WriteStartElement("currentPrice");
                writer.WriteString("24.99");
                writer.WriteEndElement();

                writer.WriteStartElement("number");
                writer.WriteString("360");
                writer.WriteEndElement();

                writer.WriteStartElement("description");
                writer.WriteString("Brawurowa, błyskotliwa, poruszająca i pełna akcji nowa powieść jednego z najpopularniejszych polskich pisarzy. Kwestia ceny to thriller przygodowy na nowe czasy.");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Product");

                writer.WriteAttributeString("productId", "4");

                writer.WriteStartElement("productType");
                writer.WriteString("Ebook");
                writer.WriteEndElement();

                writer.WriteStartElement("productName");
                writer.WriteString("Pod kluczem");
                writer.WriteEndElement();

                writer.WriteStartElement("currentPrice");
                writer.WriteString("24.99");
                writer.WriteEndElement();

                writer.WriteStartElement("number");
                writer.WriteString("360");
                writer.WriteEndElement();

                writer.WriteStartElement("description");
                writer.WriteString("Brawurowa, błyskotliwa, poruszająca i pełna akcji nowa powieść jednego z najpopularniejszych polskich pisarzy. Kwestia ceny to thriller przygodowy na nowe czasy.");
                writer.WriteEndElement();
                writer.WriteEndElement();


                writer.WriteEndElement();

                Console.WriteLine(writer);
                writer.Close();
                LoadXml("Products.xml");
            }
        }
        
    }
}
