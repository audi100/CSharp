﻿//Write a program that reads a string from the console and replaces all series of consecutive 
//identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
using System;
using System.Text;
using System.Text.RegularExpressions;


class RemoveIdenticalLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa kkkkklllll ooouudtcccc";

        StringBuilder output = new StringBuilder();
        
        output.Append(text[0]);

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])
            {
                output.Append(text[i]);
            }
        }
        Console.WriteLine(output);
    }
}

