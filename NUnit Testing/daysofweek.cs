using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace NUnit_Testing
{
    class daysofweek
    {
        public static void week(int weekday = 0)
        {
            WriteLine("\ndayOfWeek\n");
                // input weekday number
                Write("Enter weekday number (0-6) / Month number (1-12) : ");
                weekday = Convert.ToInt32(ReadLine());

                // Using switch case to validate
                switch (weekday)
                {
                    case 0:
                        WriteLine("It is SUNDAY");
                        
                    break;
                    case 1:
                        WriteLine("It is MONDAY");
                        WriteLine("\nIt is January");
                    break;
                    case 2:
                        WriteLine("It is TUESDAY");
                    WriteLine("\nIt is February");
                    break;
                    case 3:
                        WriteLine("It is WEDNESDAY");
                    WriteLine("\nIt is March");
                    break;
                    case 4:
                        WriteLine("It is THURSDAY");
                    WriteLine("\nIt is April");
                    break;
                    case 5:
                        WriteLine("It is FRIDAY");
                    WriteLine("\nIt is May");
                    break;
                    case 6:
                        WriteLine("It is SATURDAY");
                    WriteLine("\nIt is June");
                    break;
                case 7:
                    
                    WriteLine("\nIt is July");
                    break;
                case 8:
                    
                    WriteLine("\nIt is August");
                    break;
                case 9:
                    
                    WriteLine("\nIt is September");
                    break;
                case 10:
                    
                    WriteLine("\nIt is October");
                    break;
                case 11:
                    
                    WriteLine("\nIt is November");
                    break;
                case 12:
                    
                    WriteLine("\nIt is December");
                    break;

                // if  value is mis-matched
                default:
                        WriteLine("It is wrong input");
                        break;
                }


            }
        }
    }