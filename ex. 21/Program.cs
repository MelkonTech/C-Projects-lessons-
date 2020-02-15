using System;

namespace ex._21_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a different from each other numbers");
            Console.Write("Number 1 = ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2 = ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 3 =");
            int num3 = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter lesson number(21-30) [default 21]:  ");
                string lesson_number = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Red;
                switch (lesson_number)
                {
                    case "21": ex21(num1, num2, num3); break;
                    case "22": ex22(num1, num2, num3); break;
                    case "23": ex23(num1, num2, num3); break;
                    case "24": ex24(num1, num2, num3); break;
                    case "25": ex25(num1, num2, num3); break;
                    case "26": ex26(num1, num2, num3); break;
                    case "27": ex27(num1, num2, num3); break;
                    case "28": ex28(num1, num2, num3); break;
                    case "29": ex29(num1, num2, num3); break;
                    case "30": ex30(num1, num2, num3); break;
                    default: ex21(num1, num2, num3); break;
                }
            }
            static void ex21(int num1,int num2,int num3)
            {
                Console.WriteLine("Exercise 21.");
                Console.ResetColor();

                int max = num1;

                if (num2 > max)
                {
                    max = num2;
                }
                if (num3 > max)
                {
                    max = num3;
                }
                Console.WriteLine($"Maximum: {max}");
            }
            static void ex22(int num1, int num2, int num3)
            {
                Console.WriteLine("Exercise 22.");
                Console.ResetColor();

                int min = num1;

                if (num2 < min)
                {
                    min = num2;
                }
                if (num3 < min)
                {
                    min = num3;
                }
                Console.WriteLine($"Minimum: {min}");
            }
            static void ex23(int num1, int num2, int num3)
            {
                Console.WriteLine("Exercise 23.");
                Console.ResetColor();

                if (num1 == 1 || num2 == 1 || num3 == 1)
                {
                    Console.WriteLine(true);
                }
                else { Console.WriteLine(false); }

            }
            static void ex24(int num1, int num2, int num3)
            {
                Console.WriteLine("Exercise 24.");
                Console.ResetColor();

                Console.WriteLine("Soon...");

            }
            static void ex25(int num1, int num2, int num3)
            {
                Console.WriteLine("Exercise 25.");
                Console.ResetColor();

                Console.WriteLine("Soon...");

            }
            static void ex26(int num1, int num2, int num3)
            {
                Console.WriteLine("Exercise 26.");
                Console.ResetColor();

                Console.WriteLine("Soon...");

            }
            static void ex27(int num1, int num2, int num3)
            {
                Console.WriteLine("Exercise 27.");
                Console.ResetColor();

                Console.WriteLine("Soon...");

            }
            static void ex28(int num1, int num2, int num3)
            {
                Console.WriteLine("Exercise 28.");
                Console.ResetColor();

                Console.WriteLine("Soon...");

            }
            static void ex29(int num1, int num2, int num3)
            {
                Console.WriteLine("Exercise 29.");
                Console.ResetColor();

                if (num1 < num2 && num1 < num3)
                {
                    if (num2 < num3) Console.WriteLine($"{num1}, {num2}, {num3}");
                    else Console.WriteLine($"{num1}, {num3}, {num2}");
                }
                else if (num2 < num1 && num2 < num3)
                {
                    if (num1 < num3) Console.WriteLine($"{num2}, {num1}, {num3}");
                    else Console.WriteLine($"{num2}, {num3}, {num1}");

                }
                else
                {
                    if (num1 > num2) Console.WriteLine($"{num3}, {num1}, {num2}");
                    else Console.WriteLine($"{num3}, {num2}, {num1}");
                }

            }
            static void ex30(int num1, int num2, int num3)
            {
                Console.WriteLine("Exercise 30.");
                Console.ResetColor();

                if (num1 > num2 && num1 > num3)
                {
                    if (num2 > num3) Console.WriteLine($"{num1}, {num2}, {num3}");
                    else Console.WriteLine($"{num1}, {num3}, {num2}");
                }
                else if (num2 > num1 && num2 > num3)
                {
                    if (num1 > num3) Console.WriteLine($"{num2}, {num1}, {num3}"); 
                    else Console.WriteLine($"{num2}, {num3}, {num1}");

                }else
                {
                    if (num1 > num2) Console.WriteLine($"{num3}, {num1}, {num2}"); 
                    else Console.WriteLine($"{num3}, {num2}, {num1}");
                }

            }

        }
    }
}
