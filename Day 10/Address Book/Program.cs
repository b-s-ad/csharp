using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AddressBook // Day 10 UC 3

{
    class Program
    { 
    static void Main(string[] args)
    {

        AddressBook addressBook = new AddressBook();

        PromptUser();

        void Menu()
        {
            WriteLine("\n\tWelcome to Address Book Program\n");
            WriteLine("\nPlease Choose below Option\n\n");   
            WriteLine("1.Add a New contact.\n");
            WriteLine("2.View the list of All Contacts.\n");
            WriteLine("3.Modidy a Existing Contact\n");
            WriteLine("4.To Exit Now [or] Anytime.\n");
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
                    Write("Enter a First name: ");
                    firstname = ReadLine().Trim();
                    switch (firstname)
                    {
                        case "4":
                            break;
                            default:
                                Write("Enter a Last name: ");
                            lastname = ReadLine().Trim();
                            switch (lastname)
                            {
                                case "4":
                                    break;
                                default:

                                        Write("Enter an address: ");
                                        address = ReadLine().Trim();
                                        switch (address)
                                        {
                                            case "4":
                                                break;
                                            default:

                                                Write("Enter the City: ");
                                    city = ReadLine().Trim();
                                    switch (city)
                                    {
                                        case "4":
                                            break;
                                            default:
                                            case "1":
                                            Write("Enter the state: ");
                                            state = ReadLine().Trim();
                                            switch (state)
                                            {
                                                case "4":
                                                    break;
                                                default:

                                                case "1":
                                                    Write("Enter the Zip: ");
                                                    zip = ReadLine().Trim();
                                                    switch (zip)
                                                    {
                                                        case "4":
                                                            break;
                                                        default:

                                                        case "1":
                                                            Write("Enter the Phone NUmber: ");
                                                            phonenumber = ReadLine().Trim();
                                                            switch (phonenumber)
                                                            {
                                                                case "4":
                                                                    break;
                                                                default:

                                                                case "1":
                                                                    Write("Enter a Email : ");
                                                                    email = ReadLine().Trim();
                                                                    switch (email)
                                                                    {
                                                                        case "4":
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

                    
        case "2":
                        WriteLine(addressBook.ViewContactsList());
        break;
                    case "3":
                        WriteLine("Please enter the name of the Contact you wish to update");
                        firstname = ReadLine();
                        addressBook.UpdateContact(firstname);
                        break;

    }
}
        void PromptUser()
        {
            Menu();
            string userInput = "";
            while (userInput != "4")
            {
                WriteLine("\n\nChoose Any Option [1|2|3|4] : \n\n");
                    userInput = ReadLine().Trim();
                UpdateAddressBook(userInput);
            }
        }
    }
}
}


    