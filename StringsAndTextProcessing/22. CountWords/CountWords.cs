//Write a program that reads a string from the console and lists all different words in the string along 
//with information how many times each word is found.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        string input = "prela baba tri 4%^&!nedeli, ta izprela tri kadeli! prela baba tri 4%^&!nedeli, ta izprela tri kadeli! prela baba tri 4%^&!nedeli, ta izprela tri kadeli!";
        string[] words = Regex.Split(input, @"[\W+0-9_~!@#$%^&*()_+,=-`/?.,<>\|'"";:]");
        Dictionary<string, int> countWords = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i]!=String.Empty)
            {
                if (countWords.ContainsKey(words[i]))
                {
                    countWords[words[i]]++;
                }
                else
                {
                    countWords.Add(words[i], 1);
                }
            }
        }
        var sortedLetters = countWords.OrderBy(x => x.Key);
        foreach (var letter in sortedLetters)
        {
            Console.WriteLine("Letter --> {0,15}  Number --> {1,4}", letter.Key, letter.Value);
        }
    }
}

