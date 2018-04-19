using System;
using static System.Console;

namespace NestedForApp
{
    class Nested
    {
        static void Main(string[] args)
        {
            //Class Variable
            Random numb = new Random(); //Random Number Generator
            // Multiplication tables         
            for (int outer = 1; outer <= 10; outer++)
            {
                int s = numb.Next(0, 6);
                switch (s)
                {
                    case 1:
                        ForegroundColor = ConsoleColor.Black; break;
                        BackgroundColor = ConsoleColor.DarkGreen;
                    case 2:
                        ForegroundColor = ConsoleColor.Blue; break;
                        BackgroundColor = ConsoleColor.Yellow; break;
                    case 3:
                        ForegroundColor = ConsoleColor.Cyan; break;
                        BackgroundColor = ConsoleColor.White; break;
                    default:
                        ForegroundColor = ConsoleColor.Green; break;
                        BackgroundColor = ConsoleColor.Black; break;
                }

                for (int inner = 1; inner <= 10; inner++)
                {
                    WriteLine("{0} x {1} = {2}",
                        outer,
                        inner,
                        outer * inner); 
                } //End of Inner
                
            } //End of Outer
            Read();
        } //End of Main
    } //End of Class
} //End of Solution
