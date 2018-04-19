using System;
using System.Windows.Forms;
namespace SquaredValuesApp
{
    class SquaredValues
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string result = "\tn     Squared\n";
            // Loop 10 times


            //while (counter < 10)
            //for (int counter = 1; counter <= 10; counter++)
            for (; counter < 10; counter++)
            {
                //counter++;
                result += " \t"
                        + counter
                        + " \t"
                        + Math.Pow(counter, 2)
                        + "\n";
            }// End of While

            MessageBox.Show(result, "1 - 10 and their squares",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);
        }// End of Main
    }// End of Class
}// End of Solution
