//Write extension method to the String class that capitalizes the first letter of each word.
//Use the method TextInfo.ToTitleCase().

//OLD TASK NUMBER 7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

public static class CapitalFirstLetterExtension
{
    public static string CapitalFirstLetter(this string input)
    {
        TextInfo capitalFirst = new CultureInfo("en-US", false).TextInfo;
        string result = capitalFirst.ToTitleCase(input);
        return result;
    }
    static void Main()
    {
        string text = "lucky numbers in the sky";
        Console.WriteLine(text.CapitalFirstLetter());
    }
}

