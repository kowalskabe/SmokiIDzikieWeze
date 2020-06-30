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
    public class CustomerRepository : IPersonRepository
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
        
        
        

        public List<Customer> Add(Customer newCustomer)
        {

            XElement doc = XElement.Load("Customers.xml");
            IEnumerable<XElement> customers =
                from customer in doc.Elements("Customer")
                select customer;

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Encoding = Encoding.Unicode,
                Indent = true
            };

            //starting data
            using (XmlWriter writer = XmlWriter.Create("Customers.xml", settings))
            {
                writer.WriteStartElement("Customers");
                foreach (XElement customer in customers)
                {
                    writer.WriteStartElement("Customer");

                    writer.WriteAttributeString("customerId", customer.Attribute("customerId").Value);

                    writer.WriteStartElement("firstName");
                    writer.WriteString(customer.Element("firstName").Value);
                    writer.WriteEndElement();

                    writer.WriteStartElement("surname");
                    writer.WriteString(customer.Element("surname").Value);
                    writer.WriteEndElement();

                    writer.WriteStartElement("email");
                    writer.WriteString(customer.Element("firstName").Value);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteStartElement("Customer");

                writer.WriteAttributeString("customerId", Customer.lastId.ToString());

                writer.WriteStartElement("firstName");
                writer.WriteString(newCustomer.FirstName);
                writer.WriteEndElement();

                writer.WriteStartElement("surname");
                writer.WriteString(newCustomer.Surname);
                writer.WriteEndElement();

                writer.WriteStartElement("email");
                writer.WriteString(newCustomer.Email);
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Close();
                
            }

            LoadXml("Customers.xml");

            return Retrieve();
        }

        public List<Customer> Update(Customer editedCustomer)
        {
            XDocument doc = XDocument.Load("Customers.xml");
            int i = editedCustomer.CustomerId;
            
            XElement customer =
                (from cust in doc.Descendants("Customer")
                 where cust.Attribute("customerId").Value == i.ToString()
                 select cust).SingleOrDefault();

            if (customer != null)
            {
                customer.Element("firstName").Value = editedCustomer.FirstName;
                customer.Element("surname").Value = editedCustomer.Surname;
                customer.Element("email").Value = editedCustomer.Email;
            }
            
            doc.Save("Customers.xml");
            return Retrieve();
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

    
        //data for start
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
                writer.WriteString("stojakk@gmail.com");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Customer");

                writer.WriteAttributeString("customerId", "2");

                writer.WriteStartElement("firstName");
                writer.WriteString("Katarzyna");
                writer.WriteEndElement();

                writer.WriteStartElement("surname");
                writer.WriteString("Czarnecka");
                writer.WriteEndElement();

                writer.WriteStartElement("email");
                writer.WriteString("czarnecka@gmail.com");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Customer");

                writer.WriteAttributeString("customerId", "3");

                writer.WriteStartElement("firstName");
                writer.WriteString("Joanna");
                writer.WriteEndElement();

                writer.WriteStartElement("surname");
                writer.WriteString("Pawłowska");
                writer.WriteEndElement();

                writer.WriteStartElement("email");
                writer.WriteString("pawlowskaj@gmail.com");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Customer");

                writer.WriteAttributeString("customerId", "4");

                writer.WriteStartElement("firstName");
                writer.WriteString("Sylwia");
                writer.WriteEndElement();

                writer.WriteStartElement("surname");
                writer.WriteString("Czupajło");
                writer.WriteEndElement();

                writer.WriteStartElement("email");
                writer.WriteString("czupajlos@gmail.com");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Customer");

                writer.WriteAttributeString("customerId", "5");

                writer.WriteStartElement("firstName");
                writer.WriteString("Ewa");
                writer.WriteEndElement();

                writer.WriteStartElement("surname");
                writer.WriteString("Kowalska");
                writer.WriteEndElement();

                writer.WriteStartElement("email");
                writer.WriteString("kowalskae@gmail.com");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Customer");

                writer.WriteAttributeString("customerId", "6");

                writer.WriteStartElement("firstName");
                writer.WriteString("Barbara");
                writer.WriteEndElement();

                writer.WriteStartElement("surname");
                writer.WriteString("Kowalska");
                writer.WriteEndElement();

                writer.WriteStartElement("email");
                writer.WriteString("kowalskab@gmail.com");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Customer");

                writer.WriteAttributeString("customerId", "7");

                writer.WriteStartElement("firstName");
                writer.WriteString("Mateusz");
                writer.WriteEndElement();

                writer.WriteStartElement("surname");
                writer.WriteString("Janas");
                writer.WriteEndElement();

                writer.WriteStartElement("email");
                writer.WriteString("janasm@gmail.com");
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
