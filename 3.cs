using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 31;
            int y = 32;
            int z = 44;
            Console.WriteLine(Comparison(x, y, z));
        }

        static int Comparison(int a, int b, int c)
        {
            int maximumValue = a;
            if (b > a)
            {
                maximumValue = b;
            }
            else
            {
                if (c>a)
                {
                    maximumValue = c;

                }
                
            }

            return maximumValue;

        }
    }
}
