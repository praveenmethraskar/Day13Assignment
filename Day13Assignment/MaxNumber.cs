using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Assignment
{
    public class MaxNumber
    {
        public void MaxNumber_Three()
        {
            float first, second, third;
            Console.WriteLine("Enter Three Numbers to compare which is largest");
            first = float.Parse(Console.ReadLine());
            second = float.Parse(Console.ReadLine());
            third = float.Parse(Console.ReadLine());

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
