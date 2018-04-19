using System;
using static System.Console;

namespace DoWhileApp
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            int counter = 0;
            // Print a range of numbers
            // Bottom controlled loop
            // Will always execute loop body one time
            do
            {
                counter++;
                WriteLine("Counter is {0}...Square is {1}",
                    counter, counter * counter);
            } while (counter < 10);
            ReadKey();
                      
        }// End of Main
    }// End of Class
}// End fo Solution
