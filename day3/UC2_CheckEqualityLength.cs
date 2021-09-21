using System;
using System.Collections.Generic;
using System.Text;

namespace day3
{
    class UC2_CheckEqualityLength
    {
        public static void CheckEqualityLength()
        {
            Console.WriteLine("\nUC2 check equality of 2 Lengths\n");
            Console.WriteLine("Line ONE");
            Console.WriteLine("Enter (x1, y1) co-ordinates : ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter (x2, y2) co-ordinates : ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("\n\nLine TWO");
            Console.WriteLine("Enter (x_1, y_1) co-ordinates : ");
            var x_1 = Convert.ToDouble(Console.ReadLine());
            var y_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter (x_2, y_2) co-ordinates : ");
            var x_2 = Convert.ToDouble(Console.ReadLine());
            var y_2 = Convert.ToDouble(Console.ReadLine());


            double Line2 = Math.Sqrt((Math.Pow((x_2 - x_1), 2) + Math.Pow((y_2 - y_1), 2)));
            double Line1 = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));

            //Line ONE
            Console.WriteLine("Distance between co-ordinates  " + Line1);


            //Line TWO
            Console.WriteLine("Distance between co-ordinates  " + Line2);
            
            //CheckEqualityLength
            if (Line1.Equals(Line2))
                Console.WriteLine("Two Lines are equal");
            else
                Console.WriteLine("Two lines are not equal");



        }
    }
}
