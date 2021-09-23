using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AddressBook // Day 10 UC 6 // Add multiple Address Book |  Each Address Book has a unique Name's

{
    class Program
    {
        static void Main(string[] args)
        {

            AddressBook addressBook = new AddressBook();

            PromptUser();

            void Menu()
            {
                WriteLine("\n\tWelcome to Address Book Program : \n");
                WriteLine("\nPlease Choose below Option :\n\n");
                WriteLine("1.Add a New Contact / Multiple Contact | Unique New Name.\n");
                WriteLine("2.View the List of All Contacts | | Unique Name Contact.\n");
                WriteLine("3.Modidy a Existing Contact\n");
                WriteLine("4.Remove Contact\n");
                WriteLine("5.To Exit Now [or] Anytime.\n");

            }

            void UpdateAddressBook(string userInput)
            {
                string firstname = "";
                string lastname = "";
                string address = "";
                string city = "";
                string state = "";
                string zip = "";
                string phonenumber = "";
                string email = "";


                switch (userInput.ToLower())
                {
                    case "1":
                        Write("Enter the First Name : ");
                        firstname = ReadLine().Trim();
                        switch (firstname)
                        {
                            case "5":
                                break;
                            default:
                                Write("Enter the Last Name : ");
                                lastname = ReadLine().Trim();
                                switch (lastname)
                                {
                                    case "5":
                                        break;
                                    default:

                                        Write("Enter the Address : ");
                                        address = ReadLine().Trim();
                                        switch (address)
                                        {
                                            case "5":
                                                break;
                                            default:

                                                Write("Enter the City : ");
                                                city = ReadLine().Trim();
                                                switch (city)
                                                {
                                                    case "5":
                                                        break;
                                                    default:
                                                    case "1":
                                                        Write("Enter the State : ");
                                                        state = ReadLine().Trim();
                                                        switch (state)
                                                        {
                                                            case "5":
                                                                break;
                                                            default:

                                                            case "1":
                                                                Write("Enter the Zip : ");
                                                                zip = ReadLine().Trim();
                                                                switch (zip)
                                                                {
                                                                    case "5":
                                                                        break;
                                                                    default:

                                                                    case "1":
                                                                        Write("Enter the Phone Number : ");
                                                                        phonenumber = ReadLine().Trim();
                                                                        switch (phonenumber)
                                                                        {
                                                                            case "5":
                                                                                break;
                                                                            default:

                                                                            case "1":
                                                                                Write("Enter the Email : ");
                                                                                email = ReadLine().Trim();
                                                                                switch (email)
                                                                                {
                                                                                    case "5":
                                                                                        break;
                                                                                    default:

                                                                                        addressBook.AddEntry(firstname, lastname, address, city, state, zip, phonenumber, email);
                                                                                        break;
                                                                                }
                                                                                break;
                                                                        }
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    case "4":
                        Console.Write("Enter a name to remove: ");
                        firstname = Console.ReadLine();
                        switch (firstname)
                        {
                            case "5":
                                break;
                            default:
                                addressBook.RemoveEntry(firstname);
                                break;
                        }
                        break;

                    case "2":
                        WriteLine(addressBook.ViewContactsList());
                        break;
                    case "3":
                        WriteLine("Please enter the existing name of the Contact you wish to update/modify : ");
                        firstname = ReadLine();
                        addressBook.UpdateContact(firstname);
                        break;

                }
            }
            void PromptUser()
            {
                Menu();
                string userInput = "";
                while (userInput != "5")
                {
                    WriteLine("\n\nChoose Any Option [1|2|3|4|5] : \n\n");
                    userInput = ReadLine().Trim();
                    UpdateAddressBook(userInput);
                }
            }
        }
    }
}