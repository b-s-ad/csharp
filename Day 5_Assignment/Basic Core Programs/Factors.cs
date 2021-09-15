using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Factors
    {
        public static void Factor()
        {
                int n, i;
                Console.WriteLine("\nComputes the prime factorization of N using brute force");
                Console.WriteLine("\n\nTraverse till i*i <= N instead of i <= N for efficiency\n");
                Console.WriteLine("Please enter your integer: ");
                n = int.Parse(Console.ReadLine());
                for (i = 1; i+i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i + " is a factor of " + n);
                    }
                }
            }
        }
    }
