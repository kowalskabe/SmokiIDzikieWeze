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

        public Customer Retrieve (int customerId)
        {
            //tmp
            Customer customer = new Customer("Barbara", "Kowalska", "kowaska.barbara@gmail.com");
            
            return customer;
        }
        public List<Customer> Retrieve()
        {
            customers.Add(new Customer("Barbara", "Kowalska", "kowaska.barbara@gmail.com"));
            customers.Add(new Customer("Katarzyna", "Czarnecka", "czarnecka.katarzyna@gmail.com"));
            customers.Add(new Customer("Sylwia", "Czupajło", "czupajlo.sylwia@gmail.com"));
            customers.Add(new Customer("Joanna", "Pawłowska", "pawlowska.joanna@gmail.com"));
            return customers;
        }
        
    }
}
