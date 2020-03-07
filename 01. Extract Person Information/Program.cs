using System;
using System.Linq;
using System.Text;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main()
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInput; i++)
            {
                string input = Console.ReadLine();
                int startNameIndex = input.IndexOf('@');
                int endNameIndex = input.IndexOf('|');
                int lengthName = endNameIndex - startNameIndex;
                string name = input.Substring(startNameIndex + 1, lengthName -1 );

                int startAgeIndex = input.IndexOf('#');
                int endAgeIndex = input.IndexOf('*');
                int lengthAge = endAgeIndex - startAgeIndex;
                string age = input.Substring(startAgeIndex + 1, lengthAge -1);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
