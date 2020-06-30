using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    interface IProductRepository
    {
        List<Product> Retrieve();
        List<Product> Add(Product newProduct, int type);
        List<Product> Delete(int i);
        List<Product> Update(Product editedCustomer);
    }
}
