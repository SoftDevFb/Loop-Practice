using System;
using static System.Console;

namespace CounterControlled
{
    class Counter
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 1;
            while (number < 11)
            {
                WriteLine("Within Loop. Number = {0}", number);
                sum += number;// sum += number is the same as sum = sum + number
                number++;
            }
            WriteLine("Sum of values 1 through 10 is " + sum);           
            ReadKey();

        }
    }
}
