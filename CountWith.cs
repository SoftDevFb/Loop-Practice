using System;
using static System.Console;

namespace CountWithUser
{
    class CountWith
    {
        static void Main(string[] args)
        {
            int sum = 0;        // holds the sum of all
            int startValue;     // supplied by user
            int endValue;       // supplied by user

            string inValue;     // temp input value
            
            //Input Module
            Write("Enter the beginning value: ");
            inValue = ReadLine();
            while (int.TryParse(inValue, out startValue) == false)
            {
                WriteLine("Invalid input - please enter a numeric digit");
                Write("Enter the last value: ");
                inValue = ReadLine();
            }
                
            Write("Enter the last value: ");
            inValue = ReadLine();
            while (int.TryParse(inValue, out endValue) == false)
            {
                WriteLine("Invalid input - please enter a numeric digit");
                Write("Enter the last value: ");
                inValue = ReadLine();
            }

            //Processing Module
            Write("Sum of values {0} through {1} ", startValue, endValue);
            // Loop Control Variable = startValue
            while (startValue <= endValue)
            {
                sum += startValue;
                startValue++;
            } // End of While

            // Output Module
            WriteLine("is {0}", sum);
            ReadKey(); 

        } // End of Main
    } // End of Class
} // End of Solution
