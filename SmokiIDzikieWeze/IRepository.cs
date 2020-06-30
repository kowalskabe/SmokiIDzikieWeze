using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    public interface IPersonRepository
    {
        List<Customer> Retrieve();
        List<Customer> Add(Customer newCustomer);
        List<Customer> Delete(int i);
        List<Customer> Update(Customer editedCustomer);
    }
}
