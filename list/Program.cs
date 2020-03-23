using System;
using System.Collections.Generic;
using System.Linq;

namespace list
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter n number:");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            Random rnd = new Random();
            Console.Write("[ ");
            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(0, 11));
                Console.Write($"{list[i]},");
            }
            Console.WriteLine(" ]");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter lesson number(1-8) [default 1]:  ");
                string lesson_number = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Red;
                switch (lesson_number)
                {
                    case "1": ex1(list); break;
                    case "2": ex2(list); break;
                    case "3": ex3(list); break;
                    case "4": ex4(list); break;
                    case "5": ex5(list, rnd); break;
                    case "6": ex6(list); break;
                    case "7": ex7(list); break;
                    case "8": ex8(list); break;

                    default: ex1(list); break;
                }
            }
        }

        private static void ex1(List<int> list)
        {
            int s = 0;
            foreach (int item in list)
            {
                if (list.FindAll(x => x == item).Count() == 1) s++;
            }
            Console.WriteLine($"unique numbers count = {s}");
        }

        private static void ex2(List<int> list)
        {
            bool t = false;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] == list[j] && i != j)
                    {
                        t = true;
                        Console.WriteLine($"list[{i}] = list[{j}] | {list[i]} == {list[j]}");
                        goto End;
                    }
                }
            }
        End:
            if (!t)
            {
                Console.WriteLine($"Numbers not found...");
            }
        }

        private static void ex3(List<int> list)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < list.Count; i++) { numbers.Add(i + 1); }
            list.ForEach(item =>
            {
                foreach (int num in numbers)
                {
                    if (item == num) { numbers.Remove(num); break; }
                }
            });
            if (numbers.Count == 0) { Console.WriteLine("1"); }
            else
            {
                Console.WriteLine("0");
            }
        }

        private static void ex4(List<int> list)
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i < list.Count; i++)
            {
                numbers.Add(list[i]);
            }
            numbers.Sort((x, y) => x.CompareTo(y));
            numbers.Insert(0, list[0]);
            printArray(numbers);
            numbers.Sort((x, y) => x.CompareTo(y));
            printArray(numbers);
        }

        private static void ex5(List<int> list, Random rnd)
        {
            List<int> numbers = new List<int>();

            int n = rnd.Next(0, list.Count);

            for (int i = 1; i < n; i++)
            {
                numbers.Add(list[i]);
            }
            for (int i = n + 1; i < list.Count; i++)
            {
                numbers.Add(list[i]);
            }
            numbers.Sort((x, y) => x.CompareTo(y));
            numbers.Insert(n, list[n]);
            printArray(numbers);
            numbers.Sort((x, y) => x.CompareTo(y));
            printArray(numbers);
        }

        private static void ex6(List<int> list)
        {
            list.Remove(list.Max());
            printArray(list);
        }

        private static void ex7(List<int> list)
        {
            int i = 0;
            List<int> newList = new List<int>(list.Count);
            for (int j = 0; j < list.Count; j++)
            {
                newList.Add(list[j]);
            }
            while (i < newList.Count)
            {
                while (newList.FindAll(x => x == newList[i]).Count() > 1)
                {
                    newList.RemoveAt(newList.LastIndexOf(newList[i]));
                }
                i++;
            }
            printArray(list);
        }

        private static void ex8(List<int> list)
        {
            int i = 0;
            while (i < list.Count)
            {
                while (list.FindAll(x => x == list[i]).Count() > 2)
                {
                    list.RemoveAll(x => x == list[i]);
                }
                i++;
            }
            printArray(list);
        }

        private static void printArray(List<int> list)
        {
            Console.Write("[ ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]},");
            }
            Console.WriteLine(" ]");
        }
    }
}