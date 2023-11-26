using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tung_Lab4
{
    internal class regular:seats
    {
        public static int Rcount = 0; //count for regular seats
        public static void Cal() //caculate the total regular seat and total price
        {
            for (int i = 1; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    if (seat[i, j] == 'X')
                    {

                        matinee.Price += 10;
                        ++Rcount;
                    }
                }
            };
            Console.WriteLine("The number of regular seat(s) purchase is " + Rcount);
            Console.WriteLine("The total price of the seat(s) are " + matinee.Price);
        }
    }
}
