using System;

namespace metod
{
    internal class Program
    {

        static void PrintLine(string symbol, int SymbolsCount)
        {
            for (int i = 0; i < SymbolsCount; i++)
            {
                Console.Write(symbol);
            }


        }
        static void Main(string[] args)
        {
            Console.Write("введите количество символов:");
            int SymbolsCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите символ:");
            string symbol = Console.ReadLine();
            PrintLine(symbol, SymbolsCount);

        }
    }
}
