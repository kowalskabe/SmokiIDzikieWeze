using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SmokiIDzikieWeze
{
    public class CustomerRepository
    {
        private List<Customer> customersRepository = new List<Customer>();
        
        
        String ResultText = String.Empty;
        private Customer entity;
        public Customer Entity
        {
            get { return entity; }
            set 
            {
                entity = value;
            }
        }
        
        public Customer Retrieve (int customerId)
        {
            //tmp
            Customer customer = new Customer(0, "Barbara", "Kowalska", "kowaska.barbara@gmail.com");
           
            return customer;
        }
        public List<Customer> Retrieve()
        {
            LoadXml("Customers.xml");
            GetAll();
           // Add();
            return customersRepository;
        }
        
        
        
        #region xml

        public void GetAll()
        {
            StringBuilder sb = new StringBuilder(1024);
            XElement doc = XElement.Load("Customers.xml");

            IEnumerable<XElement> customers =
                from customer in doc.Elements("Customer")
                select customer;
            
            foreach (XElement customer in customers)
            {
                sb.AppendLine(customer.Element("surname").Value);
                int id = Int32.Parse(customer.Attribute("customerId").Value);
                var record = new Customer(id , customer.Element("firstName").Value, customer.Element("surname").Value, customer.Element("email").Value);
                customersRepository.Add(record);
            }
            ResultText = sb.ToString();
            Console.WriteLine(ResultText);
        }
        
        
        
        public void CreateXmlString()
        {
            
        }

  

        public void Add()
        {
          
            XElement customer =
                new XElement("Customer",
                    new XElement("customerId", 5),
                        new XElement("firstName", "Grzegorz"),
                        new XElement("surname", "Brzęczyszczykiewicz"),
                        new XElement("email", "brzeczyszczykiewiczg@gmail.com")
                        );
        }

        public void Update()
        {
            
        }

        
        public List<Customer> Delete(int i)
        {
           
            XDocument doc = XDocument.Load("Customers.xml");

            XElement customer =
                (from cust in doc.Descendants("Customer")
                 where cust.Attribute("customerId").Value == i.ToString()
                 select cust).SingleOrDefault();

            if (customer != null)
            {
                customer.Remove();
            }
            doc.Save("Customers.xml");

            return Retrieve();
        }

    

        public void XmlWriterFormattingSave(string XmlFileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Encoding = Encoding.Unicode,
                Indent = true
            };

            //starting data
            using (XmlWriter writer = XmlWriter.Create(XmlFileName, settings))
            {
                writer.WriteStartElement("Customers");
                writer.WriteStartElement("Customer");
                
                writer.WriteAttributeString("customerId", "1");
                
                writer.WriteStartElement("firstName");
                writer.WriteString("Krzysztof");
                writer.WriteEndElement();

                writer.WriteStartElement("surname");
                writer.WriteString("Stojak");
                writer.WriteEndElement();

                writer.WriteStartElement("email");
                writer.WriteString("stojakK@gmail.com");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Customer");

                writer.WriteAttributeString("customerId", "2");

                writer.WriteStartElement("firstName");
                writer.WriteString("Katarzyna");
                writer.WriteEndElement();

                writer.WriteStartElement("surname");
                writer.WriteString("Stojak");
                writer.WriteEndElement();

                writer.WriteStartElement("email");
                writer.WriteString("stojakK@gmail.com");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteEndElement();

                Console.WriteLine(writer);
                writer.Close();
                LoadXml("Customers.xml");
                
            }
        }

        public void LoadXml(string XmlFileName)
        {
            XDocument doc = new XDocument();

            if (!File.Exists(XmlFileName))
            {
                XmlWriterFormattingSave(XmlFileName);
            }
        }

    

        #endregion
    }
}
