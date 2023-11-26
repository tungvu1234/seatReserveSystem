using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tung_Lab4
{
    internal class matinee:seats
    {
        public static int Price = 0; //total price
        public static int Mcount = 0; //count the number of matinee seats
        public static void Cal() //caculate and return result regarding price and matinee seats
        {
           
            for (int j = 0; j < seat.GetLength(1); j++)
            {
                if (seat[0, j] == 'X')
                {

                    Price += 20;
                    ++Mcount;
                }
            };
            Console.WriteLine("The number of matinee seat(s) purchase is " + Mcount);
        }
    }
}
