using System;

namespace Day13Assignment
{
    public class Program
    {


        public static void Main(string[] args)
        {
            //MaxNumber maxNumber = new MaxNumber();
            //maxNumber.MaxNumber_Three();

            //MaxString maxString = new MaxString();
            //maxString.MaxString_Three();

            MaxNumber<int> maxNumber = new MaxNumber<int>(10,20,30);
            int max = maxNumber.MaxMethod(); 
            Console.WriteLine("maximum number is " + max);

            MaxNumber<char> maxNumber1 = new MaxNumber<char>('a', 'b', 'c');
            char max1 = maxNumber1.MaxMethod(); 
            Console.WriteLine("maximum number is " + max1);


            MaxNumber<string> maxNumber2 = new MaxNumber<string>("apple", "boy", "cattle");
            string max2 = maxNumber2.MaxMethod();
            Console.WriteLine("maximum number is " + max2);

        }

    }
}