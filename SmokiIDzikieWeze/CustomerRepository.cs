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
        
        
        
        public string CreateXmlString()
        {
            XmlDocument doc = new XmlDocument();
            
            StringBuilder sb = new StringBuilder();
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                sb.Append(char.ToUpper(node.Name[0]));
                sb.Append(node.Name.Substring(1));
                sb.Append(" ");
                sb.AppendLine(node.InnerText);
            }
            return sb.ToString();
            //@"<Customers>
                 //       <Customer>
                 //           <customerId>1</customerId>
                 //           <firstName>Barbara</firstName>
                 //           <surname>Kowalska</surname>
                 //           <email>kowalskab@gmail.com</email>
                 //       </Customer>
                 //       <Customer>
                 //           <customerId>2</customerId>
                 //           <firstName>Michał</firstName>
                 //           <surname>Kułaczkowski</surname>
                 //           <email>kulaczkowskim@gmail.com</email>
                 //       </Customer>
                 //       <Customer>
                 //           <customerId>3</customerId>
                 //           <firstName>Michalina</firstName>
                 //           <surname>Kulaczkowska</surname>
                 //           <email>kulaczkowskam@gmail.com</email>
                 //       </Customer>
                 //       <Customer>
                 //           <customerId>4</customerId>
                 //           <firstName>Ewa</firstName>
                 //           <surname>Kowalska</surname>
                 //           <email>kowalskae@gmail.com</email>
                 //       </Customer>
                 //   </Customers>";
        }

        public void BuildXmlDocument()
        {
            XDocument doc = 
            new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XDocument("Customer Repository"),
                new XElement("Customers",
                    new XElement("Customer",     
                        new XElement("customerId", 1),
                        new XElement("firstName", "Barbara"),
                        new XElement("surname", "Kowalska"),
                        new XElement("email", "kowalskab@gmail.com")))
                );
            ResultText = doc.ToString();
        }

        public string LoadString()
        {
            string xml = CreateXmlString();
            XDocument doc = XDocument.Parse(xml);
            ResultText = doc.ToString();
            return ResultText;
        }

        public void Add()
        {
            string xml = CreateXmlString();

            XDocument doc = XDocument.Parse(xml);

            XElement customer =
                new XElement("Customer",
                    new XElement("customerId", 5),
                        new XElement("firstName", "Grzegorz"),
                        new XElement("surname", "Brzęczyszczykiewicz"),
                        new XElement("email", "brzeczyszczykiewiczg@gmail.com")
                        );

            doc.Root.Add(customer);
            ResultText = doc.ToString();
        }

        public void Update()
        {
            string xml = CreateXmlString();
            XDocument doc = XDocument.Parse(xml);

            XElement customer =
                (from cust in doc.Descendants("Customer")
                 where cust.Element("customerId").Value == "1"
                 select cust).SingleOrDefault();

            customer.Element("firstName").Value = "Basia";

            ResultText = doc.ToString();
        }

        
        public void Delete()
        {
            string xml = CreateXmlString();
            XDocument doc = XDocument.Parse(xml);

            XElement customer =
                (from cust in doc.Descendants("Customer")
                 where cust.Element("customerId").Value == "1"
                 select cust).SingleOrDefault();

            if (customer != null)
            {
                customer.Remove();
            }

            ResultText = doc.ToString();
        }

        public void XDocSave(string FileName)
        {
            string xml = CreateXmlString();
            XDocument doc = XDocument.Parse(xml);
            doc.Save(FileName);
            ResultText = doc.ToString();
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

        public void LoadXml(string FileName)
        {
            XDocument doc = new XDocument();

            if (!File.Exists(FileName))
            {
                XmlWriterFormattingSave(FileName);
            }
        }

    

        #endregion
    }
}
