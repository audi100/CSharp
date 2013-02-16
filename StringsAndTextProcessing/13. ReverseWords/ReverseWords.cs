using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        char[] separators = new char[] { ',', ' ', '!', '?', '.' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);

        string[] arr = Regex.Split(text, "[A-Za-z0-9#+]");
        List<string> nonLetters = new List<string>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != String.Empty)
            {
                nonLetters.Add(arr[i]);
            }
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < nonLetters.Count; i++)
        {
            if (i < words.Length)
            {
                result.Append(words[i]);
            }

            result.Append(nonLetters[i]);
        }
        Console.WriteLine(result.ToString());
        //string text = "C# is not C++, not PHP and not Delphi!";
        //char[] separators = new char[] { ',', ' ', '!', '?', '.' };
        //string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        //Array.Reverse(words);
        //List<char> letters = new List<char>();

        //for (char i = 'a'; i <= 'z'; i++)
        //{
        //    letters.Add(i);
        //}
        //for (char i = 'A'; i <= 'Z'; i++)
        //{
        //    letters.Add(i);
        //}
        //for (char i = '0'; i <= '9'; i++)
        //{
        //    letters.Add(i);
        //}
        //letters.Add('+');
        //letters.Add('-');
        //letters.Add('#');


        //string[] nonLetters = text.Split(letters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        //StringBuilder result = new StringBuilder();
        //for (int i = 0; i < nonLetters.Length; i++)
        //{
        //    if (i < words.Length)
        //    {
        //        result.Append(words[i]);
        //    }
        //    result.Append(nonLetters[i]);
        //}
        //Console.WriteLine(result.ToString());
    }
}

