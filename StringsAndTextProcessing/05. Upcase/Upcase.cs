//You are given a text. Write a program that changes the text in all regions surrounded by the tags
//<upcase> and </upcase> to uppercase. The tags cannot be nested. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Upcase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        int firstIndex = 0;
        int secondIndex = text.IndexOf("<upcase>");
        
        while (secondIndex >= 0)
        {
            Console.Write(text.Substring(firstIndex, secondIndex-firstIndex));
            firstIndex = secondIndex+8;
            secondIndex = text.IndexOf("</upcase>", secondIndex + 1);
            Console.Write(text.Substring(firstIndex, secondIndex - firstIndex).ToUpper());
            firstIndex = secondIndex + 9;
            secondIndex = text.IndexOf("<upcase>", secondIndex+1);
        }
        Console.Write(text.Substring(text.LastIndexOf("</upcase>")+9, text.Length - text.LastIndexOf("</upcase>")-9));
        Console.WriteLine();
    }
}

