using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main()
        {
            string[] morseCode = Console.ReadLine().Split("|");
            Dictionary<string, char> morse = new Dictionary<string, char>()
            {
                {".-", 'A'},{"-...", 'B'},{"-.-.", 'C'},{"-..", 'D'},{".", 'E'},{"..-.", 'F' },{"--.", 'G'},
                {"....", 'H'},{"..", 'I'},{".---", 'J' },{"-.-", 'K'},{".-..", 'L'},{"--", 'M'},{"-.", 'N'},
                {"---", 'O'},{".--.", 'P'},{"--.-", 'Q'},{".-.", 'R'},{"...", 'S'},{"-", 'T'},{"..-", 'U'},
                {"...-", 'V'},{ ".--",'W'},{"-..-", 'X'},{"-.--", 'Y'},{"--..", 'Z'}
            };
            List<string> englishCode = new List<string>();
            foreach (var item in morseCode)
            {
                string[] wordMorse = item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string wordEngl = "";
                for (int i = 0; i < wordMorse.Length; i++)
                {
                    char letter = morse.GetValueOrDefault(wordMorse[i]);
                    wordEngl += letter;
                }
                englishCode.Add(wordEngl);
            }
            Console.WriteLine(string.Join(" ", englishCode));
        }
    }
}
