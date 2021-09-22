using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook // Day 9 UC 2
{
    class Contact
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        public string Zip { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public Contact(string firstname, string lastname, string address, string city, string state, string zip, string phonenumber, string email)

        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phonenumber;
            Email = email;

        }
    }
}