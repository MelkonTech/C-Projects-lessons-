using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four-digit number");
            Console.Write("Number = ");
            short num = Convert.ToInt16(Console.ReadLine());
            int miavor = num % 10;
            int tasnavor = num / 10 % 10;
            int haryuravor = num / 100 % 10;
            int hazaravor = num / 1000 ;
            Console.WriteLine($"hazaravor: {hazaravor}, haryuravor:  {haryuravor}, tasnavor: {tasnavor}, miavor: {miavor}");

            int min = miavor;
             if (tasnavor < min)
            {
                min = tasnavor;
            }
             if (haryuravor < min)
            {
                min = haryuravor;
            }
            if (hazaravor < min)
            {
                min = hazaravor;
            }

            Console.WriteLine($"Minimum: {min}");




        }
    }
}
