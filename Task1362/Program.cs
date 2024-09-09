using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

     class Program
{
    static void Main()
    {
        string path = "C:\\Users\\JzK\\Desktop\\azaz1.txt"; 
        string text = File.ReadAllText(path);
        string[] words = Regex.Split(text.ToLower(), @"\W+").Where(w => !String.IsNullOrWhiteSpace(w)).ToArray();
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            foreach (var word in words)
        {
            if (!wordCounts.ContainsKey(word))
            {
                wordCounts[word] = 1;
            }
            else
            {
                wordCounts[word]++;
            }
        }
        var orderedWordCounts = wordCounts.OrderByDescending(x => x.Value);
            for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}. {orderedWordCounts.ElementAt(i).Key} - {orderedWordCounts.ElementAt(i).Value} ");
        }
            Console.ReadLine();
    }
}