using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    public class CustomerRepository
    {
        private List<Customer> customers = new List<Customer>();
        Customer c1 = new Customer("Barbara", "Kowalska", "kowaska.barbara@gmail.com");
        Customer c2 = new Customer("Katarzyna", "Czarnecka", "czarnecka.katarzyna@gmail.com");
        Customer c3 = new Customer("Sylwia", "Czupajło", "czupajlo.sylwia@gmail.com");
        Customer c4 = new Customer("Joanna", "Pawłowska", "pawlowska.joanna@gmail.com");
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
        
    }
}
