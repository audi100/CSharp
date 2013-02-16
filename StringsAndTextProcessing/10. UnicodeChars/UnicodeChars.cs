//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class UnicodeChars
{
    static void Main()
    {
        string input = "Hi!";
        foreach (char symbol in input)
        {
            Console.Write("\\u{0:x4}", (int)symbol);
        }
        Console.WriteLine();
    }
}

