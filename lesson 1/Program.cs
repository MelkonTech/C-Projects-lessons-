using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four-digit number");
            Console.Write("Number 1 = ");
            short num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Number 2 = ");
            short num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Number 3 =");
            short num3 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Number 4 =");
            short num4 = Convert.ToInt16(Console.ReadLine());

            short max = num1;
            short min = num1;
            if (num2 > max)
            {
                max = num2;
            }
            else if (num2 < min)
            {
                min = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            else if (num3 < min)
            {
                min = num3;
            }
            if (num4 > max)
            {
                max = num4;
            }
            else if (num4 < min)
            {
                min = num4;
            }

            Console.WriteLine($"Minimum : {min}... Maximum : {max}");
            Console.WriteLine($"Maximum by {max-min} is greater than minimum");

        }
    }
}
