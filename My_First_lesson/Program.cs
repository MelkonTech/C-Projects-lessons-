
using System;

namespace My_First_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // Փոխում ենք տեքստի գույնը կապույտ
                Console.Write(">>> Order: ");
                Console.ResetColor(); // Վերադարձնում ենք տեքստի գույնը սկզբնականին
                Console.Write("Data");
                Console.ForegroundColor = ConsoleColor.DarkGreen; // Փոխում ենք տեքստի գույնը մուգ կանաչ
                Console.Write("Parity");
                Console.ForegroundColor = ConsoleColor.Cyan; // Փոխում ենք տեքստի գույնը կապույտ
                Console.Write(" <<<");
            }
        }
    }
}
