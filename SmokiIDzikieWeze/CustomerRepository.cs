using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    public class CustomerRepository
    {

        public Customer Retrieve (int customerId)
        {
            //tmp
            Customer customer = new Customer("Barbara", "Kowalska", "kowaska.barbara@gmail.com");
            
            return customer;
        }
        
        
    }
}
