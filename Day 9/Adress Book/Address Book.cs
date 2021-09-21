using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Linq;
using System.Collections;

namespace AddressBook
{
    class Address_Book  // UC 1 Ability to create a Contacts in Address Book with first and last names, address,city, state, zip, phone number and email
    {
        static void Main(string[] args)
        { 

        ArrayList address = new ArrayList { };
        Boolean menu = true;
        
        do
        {
        WriteLine("Welcome to my address book program");
        WriteLine("*****************************\n");
        WriteLine("\nPress 1 to Create a Contacts in Address Book");
        

        WriteLine("");
        ReadLine();



        WriteLine("\nPlease Enter your Firstname");
        string str1 = "Firstname";
        str1 = ReadLine();
        string valueString1 = str1;

        WriteLine("Please Enter your Lastname");
        string str2 = "Lastname";
        str2 = ReadLine();
        string valueString2 = str2;



        WriteLine("Please Enter your Address");
        string str3 = "Address";
        str3 = ReadLine();
        string valueString3 = str3;

        WriteLine("Please Enter the State");
        string str5 = "State";
        str5 = ReadLine();
        string valueString5 = str5;
                      
        WriteLine("Please Enter the Zip");
        string str6 = "Zip";
        str6 = ReadLine();
        string valueString6 = str6;

        WriteLine("Please Enter the City");
        string str7 = "City";
        str7 = ReadLine();
        string valueString7 = str7;

        WriteLine("Please Enter the Phone Number");
        string str4 = "Phone Number";
        str4 = ReadLine();
        string valueString4 = str4;


	WriteLine("Please Enter Email");
        string str8 = "Email";
        str8 = ReadLine();
        string valueString8 = str8;

        
	WriteLine("\n\nFind below list of the stored Details that you have entered  : \n\n");

        WriteLine("Firstname you entered: " + valueString1);
        WriteLine("Lastname you entered: " + valueString2);
        WriteLine("Address you entered: " + valueString3);
        WriteLine("State you entered: " + valueString5);
        WriteLine("Zip you entered: " + valueString6);
        WriteLine("City you entered: " + valueString7);
        WriteLine("Email you entered: " + valueString8);
        WriteLine("Phone Number you entered: " + valueString4);
        ReadLine();

    }
        while (menu == true);

       
        }

    }

    }

  

