using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AddressBook  //Day 10 UC 1

{
    class Program
    { 
    static void Main(string[] args)
    {

        AddressBook addressBook = new AddressBook();

        PromptUser();

        void Menu()
        {

            WriteLine("\n\tWelcome to Address Book\n");
            WriteLine("\nPlease Choose below Option\n\n");

            WriteLine("1.Add a New contact.\n");
            WriteLine("2.View the list of All Contacts.\n");            
            WriteLine("3.To Exit Now [or] in Any option.\n");
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
                    Write("Enter the First Name: ");
                    firstname = ReadLine().Trim();
                    switch (firstname)
                    {
                        case "3":
                            break;
                            default:
                                Write("Enter the Last Name : ");
                            lastname = ReadLine().Trim();
                            switch (lastname)
                            {
                                case "3":
                                    break;
                                default:

                                        Write("Enter the Address : ");
                                        address = ReadLine().Trim();
                                        switch (address)
                                        {
                                            case "3":
                                                break;
                                            default:

                                                Write("Enter the City : ");
                                    city = ReadLine().Trim();
                                    switch (city)
                                    {
                                        case "3":
                                            break;
                                            default:
                                            case "1":
                                            Write("Enter the State : ");
                                            state = ReadLine().Trim();
                                            switch (state)
                                            {
                                                case "3":
                                                    break;
                                                default:

                                                case "1":
                                                    Write("Enter the Zip : ");
                                                    zip = ReadLine().Trim();
                                                    switch (zip)
                                                    {
                                                        case "3":
                                                            break;
                                                        default:

                                                        case "1":
                                                            Write("Enter the Phone Number : ");
                                                            phonenumber = ReadLine().Trim();
                                                            switch (phonenumber)
                                                            {
                                                                case "3":
                                                                    break;
                                                                default:

                                                                case "1":
                                                                    Write("Enter the Email : ");
                                                                    email = ReadLine().Trim();
                                                                    switch (email)
                                                                    {
                                                                        case "3":
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
                   

    }
}
        void PromptUser()
        {
            Menu();
            string userInput = "";
            while (userInput != "3")
            {
                WriteLine("\n\nChoose Any Option [1,2,3] : \n\n");                
                userInput = ReadLine().Trim();
                UpdateAddressBook(userInput);
            }
        }
    }
}
}


    