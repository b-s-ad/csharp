using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static System.Console;


namespace Logical_Programs
{
    class Prime_Number
    {
        public static void Prime()
        {
            Console.WriteLine("Program to check Prime Number or Not");
            Console.WriteLine("\n\nEnter the Number to check Prime: ");
            var ends = Convert.ToInt32(Console.ReadLine());
            bool IsPrimes = true;
            int start = 1, end=ends;

            
            Console.WriteLine($"\n\nThe prime numbers between {start} to {ends} are :");

            var numbers =
                Enumerable.Range(start, end - start)
                    .Where(IsPrime)
                    .Select(number => number)
                    .ToList();

            Console.WriteLine(string.Join(", ", numbers));

            bool IsPrime(int number)
            {
                // local function
                bool CalculatePrime(int value)
                {
                  var Allprime = Math.Sqrt(number);
/*                    we start from small to big (2, 3, 4, 5, etc...)*/
                    
                    for (var i = 2; i <= Allprime; i++)
                    {
                        if (value % i == 0)
                        {
                            return false;
                        }

                    }

/*                  Explore all factors
                    so we may know this number is prime*/
                    return true;
                }

                /*negative numbers are not be prime
                only call  CalculatePrime for non-negative*/

                return number > 1 && CalculatePrime(number);
            }
            // to check Input number is Prime or not 

            for (int i = 2; i < ends / 2; i++)
            {
                if (ends % i == 0)
                {
                    IsPrimes = false;
                    break;
                }
            }
            if (IsPrimes)
            {
                Console.Write("\n\nThe Number is Prime :  \n" + ends);
            }
            else
            {
                Console.Write( "\n\nThe Number is not Prime : \n" + ends);
            }
            Console.ReadKey();
        }
    }
}
