using System;
using static System.Console;

namespace SentinelApp
{
    class Sentinel
    {
        static void Main(string[] args)
        {
            string inValue = "";    // "" initializes to null
            
            // Output some heading info
            Write("This program will let you enter");
            Write(" value after value. To Stop, enter");
            WriteLine(" -99");
            
            // Loop until sentinel is received
            while (inValue != "-99")
            {
                Write("\nEnter value (-99 to exit): ");
                inValue = ReadLine();
            }

            ReadKey();

        } // End of Main
    } //End of Class
} //End of Solution
