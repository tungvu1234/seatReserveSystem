using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tung_Lab4
{
    internal class seats
    {
        // Creating a 2D array with 5 rows and 6 columns
        public static char[,] seat = new char[5, 6];
 
        public static void Initialize() // intitialize all seat with E
        {
            // Initialize all values to 'E' for empty
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    seat[i, j] = 'E';
                }
            }
        }

        public static void Display() //display the seats with header and labels
        {
            // Display the seat reservation system header
            Console.WriteLine("\t\tSeat Reservation System");
            Console.WriteLine(new string('*', 50)); // Header border

            // Display column labels
            Console.Write("\t"); // Initial spacing for row labels
            for (char label = 'A'; label <= 'F'; label++)
            {
                Console.Write(label + "\t");
            }
            Console.WriteLine();

            // Display the array with row labels
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                // Display row label
                Console.Write((i + 1) + "\t");
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    Console.Write(seat[i, j] + "\t");
                }
                Console.WriteLine(); // New line after each row
            }
        }
        public static void Map(int x, int y) //if seat already taken return and set X
        {
            if (seat[x, y] == 'X')
            {
                Console.WriteLine();
                Console.WriteLine("Seat is taken");
                Console.WriteLine();
            }
            else
            {
                seat[x, y] = 'X';
            }
        }
    }
}
