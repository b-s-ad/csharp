using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace day3
{
    class UC4_Equal_Compare //Day8 UC4 Equals & compare 2 Lengths
    {
        public static void Equal_Compare()
        
            {
                WriteLine("\n\tUC4 Equals & compare 2 Lengths\n");
                WriteLine("\nLine ONE");
                WriteLine("\nEnter (x1, y1) co-ordinates : ");
                var x1 = Convert.ToDouble(ReadLine());
                var y1 = Convert.ToDouble(ReadLine());
                WriteLine("\nEnter (x2, y2) co-ordinates : ");
                var x2 = Convert.ToDouble(ReadLine());
                var y2 = Convert.ToDouble(ReadLine());



                WriteLine("\n\nLine TWO");
                WriteLine("\nEnter (x_1, y_1) co-ordinates : ");
                var x_1 = Convert.ToDouble(ReadLine());
                var y_1 = Convert.ToDouble(ReadLine());
                WriteLine("\nEnter (x_2, y_2) co-ordinates : ");
                var x_2 = Convert.ToDouble(ReadLine());
                var y_2 = Convert.ToDouble(ReadLine());


                double Line2 = Math.Sqrt((Math.Pow((x_2 - x_1), 2) + Math.Pow((y_2 - y_1), 2)));
                double Line1 = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));

                //Line ONE
                WriteLine("\nDistance between co-ordinates  " + Line1);


                //Line TWO
                WriteLine("Distance between co-ordinates  " + Line2);

                //Comparing Two Lines
                var compare = Line1.CompareTo(Line2);


                if (compare > 0)
                    WriteLine("\nLine 1  is greater than Second Line Line 2");
                else if (compare < 0)
                    WriteLine("\n\tLine 2 is greater than First Line Line 1");
                else
                    WriteLine("");

            /* CheckEqualityLength*/
            {
                if (Line1.Equals(Line2))
                    WriteLine("\n\tBoth Lines are equal");
                else
                    WriteLine("\n\tlines are not equal");
            }


            }
        }
}
