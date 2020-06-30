using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string surname;
        private string email;
        public static int lastId = 0;
        public Customer()
        {

        }

        public Customer(int id, string firstName, string surname, string email)
        {
            //NumberOfCustomers += 1;
            this.customerId = id;
            this.firstName = firstName;
            this.surname = surname;
            this.email = email;
            if (lastId < this.customerId)
            {
                lastId += 1;
            }

        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string FullName() => FirstName + " " + Surname;

        public override string ToString()
        {
            return $"{CustomerId}\t {FullName()}";
        }
    }
}
