using System;
using System.Collections.Generic;

namespace _05._HTML
{
    class Program
    {
        static void Main()
        {
            string[] article = new string[] {"<h1>", "</h1>" };
            string[] content = new string[] {"<article>", "</article>" };
            string[] comment = new string[] {"<div>", "</div>" };
            Dictionary<string[], List<string>> htmlContent = new Dictionary<string[], List<string>>();

            string articleInput = Console.ReadLine();
            string contentInput = Console.ReadLine();
            htmlContent.Add(article, new List<string> { articleInput });
            htmlContent.Add(content, new List<string> { contentInput });

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of comments")
                {
                    break;
                }
                string commentInput = input;
                if (!htmlContent.ContainsKey(comment))
                {
                    htmlContent.Add(comment, new List<string> { commentInput });
                }
                else
                {
                    htmlContent[comment].Add(commentInput);
                }
            }
            foreach (var item in htmlContent)
            {
                foreach (var text in item.Value)
                {
                    Console.WriteLine(item.Key[0]);
                    Console.WriteLine($"    {text}");
                    Console.WriteLine(item.Key[1]);
                }  
            }
        }
    }
}
