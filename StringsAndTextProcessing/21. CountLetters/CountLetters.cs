using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class CountLetters
{
    static void Main()
    {
        string input = "prela baba tri 4%^&!nedeli, ta izprela tri kadeli!";
        string[] words = Regex.Split(input, @"[\W+0-9_~!@#$%^&*()_+,=-`/?.,<>\|'"";:]");
        Dictionary<char, int> countchars = new Dictionary<char, int>();
        for (int i = 0; i < words.Length; i++)
        {
            foreach (var character in words[i])
            {              
                if (countchars.ContainsKey(character))
                {
                    countchars[character]++;
                }
                else
                {
                    countchars.Add(character, 1);
                }
            }
        }
       var sortedLetters = countchars.OrderBy(x => x.Key);
        foreach (var letter in sortedLetters)
        {
            Console.WriteLine("Letter --> {0} - Number --> {1}", letter.Key, letter.Value);
        }

    }
}

