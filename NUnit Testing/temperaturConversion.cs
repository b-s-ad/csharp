using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace NUnit_Testing
{
    class temperaturConversion
    {
        public static void tempcon()
        {
            WriteLine("TemperaturConversion Celsius(°C) to Fahrenheit (°F)");
            int celsius, faren;
            WriteLine("\nEnter the Temperature Celsius(°C) : ");
            celsius = int.Parse(ReadLine());
            faren = (celsius * 9) / 5 + 32;
            WriteLine("0 Temperature in Fahrenheit is : " + faren + "(°F) \n\n\n Press Enter\n\n");
            ReadLine();
            WriteLine("\nTemperaturConversion Fahrenheit (°F) to Celsius(°C)");
            WriteLine("\nEnter the Temperature Fahrenheit is (°F) : ");
            faren = int.Parse(ReadLine());
            celsius = (faren - 32) * 5 / 9;
            WriteLine("Temperature in Celsius is : " + celsius + "(°C)");
            ReadLine();

        }
    }
}
