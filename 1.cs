using System;

namespace sqdasdasd
{
    class Program
    {
        static void Main(string[] args)
        {
            string cuce = Console.ReadLine();
            int num = Convert.ToInt32(cuce);
            Console.WriteLine(Sum(num));
        }
        
        static int Sum(int number)
        {
            int sumOfNumbers = 0;
            while (number!=0)
            {
                int lastDigit = number % 10;
                sumOfNumbers += lastDigit;
                number = (number - number % 10) / 10;
                
            }

            return sumOfNumbers;
        }




    }
}
