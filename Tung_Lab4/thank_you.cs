using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tung_Lab4
{
    internal class thank_you
    {
        public static void display() //display thank you using loop
        {
            int lines = 5; // Maximum of the word Thank you

            // Loop to print the top half
            Console.WriteLine();
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("Thank you");
                    if (j < i) // Add space if it's not the last "Thank you" in the line
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Loop to print the bottom half
            for (int i = lines - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("Thank you");
                    if (j < i) // Add space if it's not the last "Thank you" in the line
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
