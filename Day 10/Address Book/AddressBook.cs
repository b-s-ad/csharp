using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AddressBook  // Day 10 UC 4
{
    class AddressBook
    {
        public readonly Contact[] contacts;

        public AddressBook()
        {
            contacts = new Contact[5]; ;
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
                        Console.WriteLine("\n\tAddress Book is Updated Now" + "\n\nThe Details you have Enter below : \n\nFirstName : {0}\tLast Name : {1}\tAddress : {2}\tCity : {3}\tState : {4}\tZip : {5}\tPhone NUmber : {6}\tEmail : {7} \n\n" +
                            "\tIts has been added in the Address Book" + "\n==============================================================================\n", firstname, lastname, address, city, state, zip, phonenumber, email);
                        return true;
                    }
                }
                Console.WriteLine($"\n\tCannot add ({firstname}) to Address Book since it is full!");
                return false;
            }
            else
            {
                Console.WriteLine($"\n\t({firstname}) already exists in Address Book!");
                UpdateContact(firstname);
            }
            return false;
        }
        public bool UpdateContact(string originalName)
        {
            Console.Write("Are you sure you would you like to update the Contact? -- Type 'Y' or 'N': ");
            string userResponse = Console.ReadLine().ToLower();
            if (userResponse == "y")
            {
                Console.Write($"Would you like to update {originalName}'s address? TYPE 'Address' for address: ");
                string contactToUpdate = Console.ReadLine().ToLower();

                Console.Write($"Please enter changes to the {contactToUpdate} here: ");
                string updatedContact = Console.ReadLine().Trim();
                updatedContact = FormatContact(updatedContact);

                int index = GetEntryIndex(originalName);
                switch (contactToUpdate)
                {
                  
                    case "address":
                        contacts[index].Address = updatedContact;
                        Console.WriteLine($"Contact {originalName}'s {contactToUpdate} updated to {updatedContact}");
                        return true;
                }
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

        public void RemoveEntry(string firstname)
        {
            var index = GetEntryIndex(firstname);
            if (index != -1)
            {
                contacts[index] = null;
                Console.WriteLine("{0} removed from contacts", firstname);
            }
        }

        public string ViewContactsList()
        {
            string contactList = "";
            foreach (Contact contact in contacts)
            {
                if (contact == null)
                {
                    continue;
                }
                contactList += String.Format("\n\nFirstName : {0}\tLast Name : {1}\tAddress : {2}\tCity : {3}\tState : {4}\tZip : {5}\tPhone NUmber : {6}\tEmail : {7} \n" + Environment.NewLine, contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State, contact.Zip, contact.PhoneNumber, contact.Email);
            }
            return (contactList != String.Empty) ? contactList : "\tYour Address Book is empty.";
        }
    }
}
