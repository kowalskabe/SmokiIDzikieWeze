using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    class Order
    {
        private int orderId;


        public Order()
        { 
        
        }
        public Order(int orderId)
        {
            OrderId = orderId; 
        }


        public int OrderId
        {
            get { return orderId; }
            private set { orderId = value; }
        }

        public DateTimeOffset? OrderDate { get; set; }


    }
}
