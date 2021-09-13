using System;
using System.Collections.Generic;
using System.Text;

namespace day3
{
    class UC1_CalculateLength
    {
        public static void CalculateLength()
        {

            Console.WriteLine("\nUC1 calculate its Length\n");
            Console.WriteLine(" Enter (x1, y1) co-ordinates : \n");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Enter (x2, y2) co-ordinates : \n");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());

            var finalResult = Distance(x1, x2, y1, y2);

            Console.WriteLine("\n Distance between co-ordinates {0},{1} and {2},{3} is {4} ", x1, y1, x2, y2, finalResult);
        }

        private static double Distance(double x1, double x2, double y1, double y2)
        {
            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp1 + temp2);

            return result;
        }
    }
}
