using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Assignment
{
    public class MaxString
    {
        public void MaxString_Three()
        {
            string first, second, third;
            Console.WriteLine("Enter Three words to compare which is largest");
            first = Console.ReadLine();
            second = Console.ReadLine();
            third = Console.ReadLine();

            int status = first.CompareTo(second);
            int status2 = first.CompareTo(third);
            int status3 = second.CompareTo(third);

            if (status > 0)
            {
                if (status2 > 0)
                {
                    Console.WriteLine("Fisrt number is maximum number " +first);
                }
                else
                {
                    Console.WriteLine("Third number is max number " +third);
                }
            }
            else if (status3 > 0)
            {
                Console.WriteLine("second is max number " +second);
            }
            else
            {
                Console.WriteLine("third is max number "+third);
            }


        }
    }
}
