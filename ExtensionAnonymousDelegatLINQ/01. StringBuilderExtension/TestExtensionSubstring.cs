//Implement an extension method Substring(int index, int length) for the class StringBuilder 
//that returns new StringBuilder and has the same functionality as Substring in the class String.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class TestExtensionSubstring
{
    static void Main()
    {
        StringBuilder input = new StringBuilder();
        input.Append("Hello, world!");
        Console.WriteLine(input.SubstringExtension(7, 5));
    }
}

