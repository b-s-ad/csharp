using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AddressBook //Day 9 UC 2
{
    class AddressBook
    {
        public readonly Contact[] contacts;

        public AddressBook()
        {
            contacts = new Contact[100]; ;
        }
        public bool AddEntry(string firstname, string lastname, string address, string city, string state, string zip, string phonenumber, string email)
        {
            if (!ContainsEntry(firstname))
            {
                firstname = FormatContact(firstname);
                lastname = FormatContact(lastname);
                address = FormatContact(address);
                city = FormatContact(city);
                state = FormatContact(state);
                zip = FormatContact(zip);
                phonenumber = FormatContact(phonenumber);
                email = FormatContact(email);
                
                
                Contact AddContact = new Contact(firstname, lastname, address, city, state, zip, phonenumber, email);
                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i] == null)
                    {
                        contacts[i] = AddContact;
                        WriteLine("==============================================================================\n");
                        Console.WriteLine("\n\tAddress Book is Updated Now"+ "\n\nThe Details you have Enter below : \n\nFirstName : {0}\nLast Name : {1}\nAddress : {2}\nCity : {3}\nState : {4}\nZip : {5}\nPhone NUmber : {6}\nEmail : {7}\n\n\t\t Its has been added in the Address Book"+ "\n==============================================================================\n", firstname, lastname, address, city, state, zip, phonenumber, email);
                        return true;
                        
                    }
                    
                }
                Console.WriteLine($"\n\tCannot add ({firstname}) to Address Book since it is full!");
                return false;
            }
            else
            {
                Console.WriteLine($"\n\t({firstname}) already exists in Address Book!");
                
            }
            return false;
        }
       
        private string FormatContact(string stringToFormat)
        {
            char[] arr = stringToFormat.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int num;
                if (i == 0 || arr[i - 1] == ' ' && !(int.TryParse(arr[i].ToString(), out num)))
                {
                    arr[i] = Convert.ToChar(arr[i].ToString().ToUpper());
                }
                else
                {
                    arr[i] = Convert.ToChar(arr[i].ToString().ToLower());
                }
            }
            return String.Concat(arr);
        }
        private int GetEntryIndex(string firstname)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] != null && contacts[i].FirstName.ToLower() == firstname.ToLower())
                    return i;
            }
            return -1;
        }

        private bool ContainsEntry(string firstname)
        {
            return GetEntryIndex(firstname) != -1;
        }

       //Contact List
        public string ViewContactsList()
        {
            string contactList = "";
            foreach (Contact contact in contacts)
            {
                if (contact == null)
                {
                    continue;
                }
                WriteLine("==============================================================================");
                contactList += String.Format("\nFirst Name : {0}\nLast Name : {1}\nAddress : {2}\nCity : {3}\nState : {4}\nZip : {5}\nPhone NUmber : {6}\nEmail : {7}\n"+"==============================================================================\n" + Environment.NewLine, contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State, contact.Zip, contact.PhoneNumber, contact.Email);
                
            }
            return (contactList != String.Empty) ? contactList : "\n\tYour Address Book is empty.";
        }
    }
}
