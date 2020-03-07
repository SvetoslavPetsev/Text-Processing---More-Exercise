using System;
using System.Text;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main()
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            string someSymbols = Console.ReadLine();
            int start = Math.Min(symbol1, symbol2);
            int end = Math.Max(symbol1, symbol2);
            int sum = 0;
            foreach (char item in someSymbols)
            {
                if (item > start && item < end)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
