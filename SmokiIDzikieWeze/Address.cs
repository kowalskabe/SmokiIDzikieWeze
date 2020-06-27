using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokiIDzikieWeze
{
    class Address
    {
        private int addressId;
        private string street;
        private string homeNumber;
        private int apartmentNumber;
        private int postalCode;
        private string city;

        Address()
        { 
        
        }

        Address(int addressId)
        {
            AddressId = addressId;
        }


        public int AddressId 
        {
            get { return addressId; }
            private set { addressId = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string HomeNumber
        {
            get { return homeNumber; }
            set { homeNumber = value; }
        }

        public int ApartmentNumer
        {
            get { return apartmentNumber; }
            set { apartmentNumber = value; }
        }

        public int PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }


    }
}
