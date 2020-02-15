using System;

namespace My_Second_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("number1 = ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("number2 = ");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            
            //Console.Write("number3 =");
            //int number3 = Convert.ToInt32(Console.ReadLine());

            //    int max = number1;
            //    if (max < number2) 
            //        {
            //        max = number2;
            //        }
            //    if (max < number3)
            //        {
            //        max = number3; 
            //        }
            //Console.WriteLine($"MAx is value = {number3}");

            //Console.ReadLine();

            int er = Convert.ToInt32(Console.ReadLine());
            int h = er / 100;
            int m = er % 10;

            int x = er / 10;
            int t = x % 10;

            Console.WriteLine($"haruravor = {h}");
            Console.WriteLine($"tasnavor = {t}");
            Console.WriteLine($"mivor = {m}");
            
                int max = t;
                if (max < m) 
                    {
                    max = m;
                    }
                if (max < h)
                    {
                    max = h; 
                    }
            Console.WriteLine($"MAx is value = {}");

            Console.ReadLine();



        }
    }
}
