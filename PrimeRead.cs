using System;
using static System.Console;

namespace PrimeReadApp
{
    class PrimeRead
    {
        static void Main(string[] args)
        {
            string inValue = "";    // "" initializes to null
            int sum = 0,
                numValue;

            // Output some heading info
            Write("This program will let you enter");
            Write(" value after value. To Stop, enter");
            WriteLine(" -99");
            
            // Priming read of data 
            Write("\nEnter value (-99 to exit): ");
            inValue = ReadLine();

            // Loop until sentinel is received
            while (inValue != "-99")
            {
                if (int.TryParse(inValue, out numValue) == false)
                    WriteLine("Invalid input - 0 stored in numValue");
                sum += numValue;
                Write("\nEnter value (-99 to exit): ");
                inValue = ReadLine();
            }
            WriteLine("Total values entered {0}", sum);
            ReadKey();

        } // End of Main
    } //End of Class
} //End of Solution
