using System;
using System.Collections.Generic;
using System.Text;
using static System.Convert;
using static System.Console;


namespace NUnit_Testing
{
    class BinaryConversion
    {
        public static void ToBinary()

        {
            WriteLine("\nCoversion Input to Binary\n\n");
            
            string answer;
            string result;

        Write("Enter a Number : ");
        answer = ReadLine();
         
            int num = ToInt32(answer);
        result = "";
            while (num > 1)
            {
                int remainder = num % 2;
        result = Convert.ToString(remainder) + result;
                num /= 2;
            }
          result = Convert.ToString(num) + result;
            WriteLine($"\nBinary of {answer}  is : "+"{0}", result);
        }
    }
}
