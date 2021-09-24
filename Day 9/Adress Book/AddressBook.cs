using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AddressBook  // Day 9 UC 4
{
    class AddressBook
    {
        public readonly Contact[] contacts;

        public AddressBook()
        {
            contacts = new Contact[2]; ;
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
                        Console.WriteLine("\n\tAddress Book is Updated Now" + "\n\nThe Details you have Enter below : \n\nFirstName : {0}\t||Last Name : {1}\t||Address : {2}\t||City : {3}\t||State : {4}\t||Zip : {5}\t||Phone Number : {6}\tEmail : {7}|| \n\n" +
                            "\tIts has been added in the Address Book" + "\n==============================================================================\n", firstname, lastname, address, city, state, zip, phonenumber, email);
                        return true;
                    }
                }
                
                Console.WriteLine($"\n\tCannot add ({firstname}) to Address Book since it is full! | Delete Existing contact , try again...");
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
            Console.Write("Are you sure you would you like to update the Contact to Unique New Name ? -- Type 'Y' or 'N': ");
            string userResponse = Console.ReadLine().ToLower();
            if (userResponse == "y")
            {
                Console.Write($"\nWould you like to update {originalName}'s Details ?\n"+ "\nTYPE : \n\n[firstname] for FirstName :\n[lastName] for LastName :\n[address] for Address :\n[city] for City :\n[state] for State :\n[zip] for Zip :\n[phonenumber] for Phonenumber :\n[email] for Email :\n\n ");
                string contactToUpdate = Console.ReadLine().ToLower();

                Console.Write($"Please enter changes to the {contactToUpdate} here: ");
                string updatedContact = Console.ReadLine().Trim();
                updatedContact = FormatContact(updatedContact);

                int index = GetEntryIndex(originalName);
                switch (contactToUpdate)
                {
                  
                    case "firstname":
                        contacts[index].FirstName = updatedContact;
                        Console.WriteLine($"Contact {originalName} updated to {updatedContact}");
                        return true;
                    case "lastname":
                        contacts[index].LastName = updatedContact;
                        Console.WriteLine($"Contact {originalName} updated to {updatedContact}");
                        return true;
                    case "address":
                        contacts[index].Address = updatedContact;
                        Console.WriteLine($"Contact {originalName} updated to {updatedContact}");
                        return true;
                    case "city":
                        contacts[index].City = updatedContact;
                        Console.WriteLine($"Contact {originalName} updated to {updatedContact}");
                        return true;
                    case "state":
                        contacts[index].State = updatedContact;
                        Console.WriteLine($"Contact {originalName} updated to {updatedContact}");
                        return true;
                    case "zip":
                        contacts[index].Zip= updatedContact;
                        Console.WriteLine($"Contact {originalName} updated to {updatedContact}");
                        return true;
                    case "phonenumber":
                        contacts[index].PhoneNumber = updatedContact;
                        Console.WriteLine($"Contact {originalName} updated to {updatedContact}");
                        return true;
                    case "email":
                        contacts[index].Email = updatedContact;
                        Console.WriteLine($"Contact {originalName} updated to {updatedContact}");
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
                contactList += String.Format("\n\nFirst Name : {0}\t|Last Name : {1}\t|Address : {2}\t|City : {3}\t|State : {4}\t|Zip : {5}\t|Phone Number : {6}\t|Email : {7} |\n" + Environment.NewLine, contact.FirstName, contact.LastName, contact.Address, contact.City, contact.State, contact.Zip, contact.PhoneNumber, contact.Email);
            }

            return (contactList != String.Empty) ? contactList : "\tYour Address Book is empty.";
        }
    }
}