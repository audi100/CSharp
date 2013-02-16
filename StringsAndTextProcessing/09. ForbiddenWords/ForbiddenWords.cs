using System;
using System.Text;
using System.Text.RegularExpressions;


class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string words = "PHP, CLR, Microsoft";
        string[] forbiddenWords = Regex.Split(words, @"\W+"); 

        StringBuilder newText = new StringBuilder();
        newText.Append(text);
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            newText = newText.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        Console.WriteLine(newText);
    }
}

