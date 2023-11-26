using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tung_Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letters = {"A", "B", "C", "D", "E", "F"}; //create an array of letter to get index number
            bool Again = true; // bool to play again
            seats.Initialize(); // innitialize the table with all value E
            while(Again)
            {
                matinee.Mcount = 0; //reset matinee count
                matinee.Price = 0; //reset price
                regular.Rcount = 0; //reset regular count
                seats.Display(); //display table
                Console.WriteLine("Enter the row number using numbers from 1 to 5"); //ask for row input
                try
                {
                    int inpRow = int.Parse(Console.ReadLine());
                    if (inpRow < 0 || inpRow > 5) //check if input is out of range from 1 to 5 and return exception
                    {
                        throw new ArgumentOutOfRangeException("The number must between 1 and 5");
                    }
                    Console.WriteLine("Enter the column using letter A to F"); //ask for column input
                    string inpCol = Console.ReadLine().ToUpper(); // user can enter lowercase
                    while (inpCol.Length != 1 || inpCol[0] < 'A' || inpCol[0] > 'F')
                    {
                        throw new ArgumentOutOfRangeException("The letter must between A and F");
                        inpCol = Console.ReadLine().ToUpper();
                    }
                    int Numcol = Array.IndexOf(letters, inpCol);// get index number base on column letter
                    seats.Map(inpRow - 1, Numcol); // draw X in appropriate seat 
                    seats.Display(); 
                    Console.WriteLine();
                    matinee.Cal(); //return matinee number of seat
                    regular.Cal(); //return regular and total price
                    Console.WriteLine();
                    Console.WriteLine("Do you want to reserve more seats? (Y/N)"); //input to play again
                    string playAgain = Console.ReadLine().ToUpper();
                    if (playAgain.Equals("N"))
                    {
                        thank_you.display(); //display thank you message
                        Again = false; // breakout of loop
                    } else if (playAgain.Equals("Y"))
                    {
                        //continue
                    }
                    else
                    {
                        throw new Exception("Please enter Y or N");
                    }

                }
                //exception catching
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); //return any exception to user
                }
            }
            Console.ReadKey();
        }
    }
}
