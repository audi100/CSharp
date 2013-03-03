//Implement an extension method Substring(int index, int length) for the class StringBuilder 
//that returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class StringBuilderExtension
{
    public static StringBuilder SubstringExtension(this StringBuilder input, int index, int length)
    {
        StringBuilder output = new StringBuilder();

        if ((index + length > input.Length) || length <= 0 || index < 0)
        {
            throw new ArgumentOutOfRangeException("Out of range argument!");
        }
        for (int i = index; i < index+length; i++)
        {
            output.Append(input[i]);
        }
        return output;
    }
}

