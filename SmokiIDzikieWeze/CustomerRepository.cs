using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SmokiIDzikieWeze
{
    public class CustomerRepository
    {
        private List<Customer> customers = new List<Customer>();
        Customer c1 = new Customer("Barbara", "Kowalska", "kowaska.barbara@gmail.com");
        Customer c2 = new Customer("Katarzyna", "Czarnecka", "czarnecka.katarzyna@gmail.com");
        Customer c3 = new Customer("Sylwia", "Czupajło", "czupajlo.sylwia@gmail.com");
        Customer c4 = new Customer("Joanna", "Pawłowska", "pawlowska.joanna@gmail.com");
        
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
            Customer customer = new Customer("Barbara", "Kowalska", "kowaska.barbara@gmail.com");
            
            return customer;
        }
        public List<Customer> Retrieve()
        {
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            return customers;
        }


    //   
    //   public void Serialize()
    //   {
    //       string ResultText = string.Empty;
    //       var serializer = new XmlSerializer(typeof(Customer));
    //       using (var sw = new StringWriter())
    //       {
    //           serializer.Serialize(sw, Entity);
    //           ResultText = sw.ToString();
    //       }
    //       WriteXmlFile(ResultText);
    //
    //       Entity = new Customer();
    //   }
    //
    //   public void WriteXmlFile(string xml)
    //   {
    //       if (!Directory.Exists(Path.GetDirectoryName(XmlFileName)))
    //       {
    //           Directory.CreateDirectory(Path.GetDirectoryName(xmlFileName));
    //       }
    //
    //       if (File.Exists(XmlFileName))
    //       {
    //           File.Delete(XmlFileName);
    //       }
    //
    //       File.AppendAllText(XmlFileName, xml, Encoding.Unicode);
    //   }
    //
    //   public void Deserialize()
    //   {
    //       Entity = new Customer();
    //
    //       var serializer = new XmlSerializer(typeof(Customer));
    //       using (var tw = new FileStream(XmlFileName, FileMode.Open))
    //       {
    //           Entity = (Customer)serializer.Deserialize(tw);
    //           tw.Close;
    //       }
    //       ResultText = string.Empty;
    //   }
    }
}
