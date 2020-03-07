using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main()
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<string> encritedCode = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "find")
                {
                    break;
                }
                encritedCode.Add(input);
            }
            foreach (string code in encritedCode)
            {
                int maxIndexKey = key.Length - 1;
                int indexKey = 0;
                StringBuilder decriptedCode = new StringBuilder();
                for (int i = 0; i < code.Length; i++)
                {
                    if (indexKey <= maxIndexKey)
                    { 
                        indexKey++;
                    }
                    else
                    {
                        indexKey = 1;
                    }
                    int decritedASCII = code[i] - key[indexKey - 1];
                    char decritedSymbol = (char)decritedASCII;
                    decriptedCode.Append(decritedSymbol);
                }
                string massage = decriptedCode.ToString();
                int startTypeIndex = massage.IndexOf("&");
                int endTypeIndex = massage.LastIndexOf("&");
                int startCoordinatesIndex = massage.IndexOf("<");
                int endCoordinatesIndex = massage.IndexOf(">");
                string type = massage.Substring(startTypeIndex + 1, endTypeIndex - startTypeIndex - 1);
                string coordinates = massage.Substring(startCoordinatesIndex +1, endCoordinatesIndex - startCoordinatesIndex - 1);
                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
