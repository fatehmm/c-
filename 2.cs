using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş interger arrayində verilmiş integer ədədinin yerləşdiyi
            //ilk indexi tapıb qaytaran metod.Əgər tapmasa -1 qaytarsın.
            //(Metodu işlətdikdə içinə arqument olaraq bir integer array və bir ədəd göndərilir)

            int[] arry = { 2, 45, 22, 45, 12, 534, 112, 43, 655 };
            int num = 31;
            int index = IndexFinder(arry, num);
            if (index!=-1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Arrayda verilen eded yoxdur");
            }
        }

        static int IndexFinder(int[] numbers, int number)
        {
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)

            {
                if (number == numbers[i])
                {
                    index = i;

                    break;
                }
            }

            return index;
        }
    }
}
