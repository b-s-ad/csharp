using System;
using System.Diagnostics;

namespace Logical_Programs
{
    public class Simulate_Stopwatch
    {
        public static void Time()
        {   
            Console.WriteLine("Stopwatch Program for measuring the time that elapses between the start and end clicks");
            Stopwatch stopwatch = new Stopwatch();
            validationstarted:
            string times = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("\nThe current time is {0}", times);
            Console.WriteLine("\nTo Start the stopwatch enter S or s.");
            char start = Convert.ToChar(Console.ReadLine());
            stopwatch.Start();

            if (start == 's' || start == 'S')
            {
            validationstopped:
                Console.WriteLine("To End the stopwatch enter E or e.");
                char end = Convert.ToChar(Console.ReadLine());
                if (end == 'E' || end == 'e')
                {
                    stopwatch.Stop();
                    Console.WriteLine("\nstopwatch stopped and The elapsed time is : " + stopwatch.Elapsed);


                }
                else
                {
                    //start message by invalid input
                    Console.WriteLine("Invalid Input" + "\nPlease retry : Check Below ");
                    goto validationstopped;
                }
            }
            else
            {
                stopwatch.Stop();
                Console.WriteLine("Invalid Input"+ "\nPlease retry : Check Below ");
                goto validationstarted;
                //stop message by invalid input
            }
        }
    }
}