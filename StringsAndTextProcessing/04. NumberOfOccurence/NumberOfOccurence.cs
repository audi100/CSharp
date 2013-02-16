//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class NumberOfOccurence
{
    static void Main()
    {
        string text=@"We are living in an yellow submarine. 
        We don't have anything else. Inside the submarine is very tight.
        So we are drinking all the day. We will move out of it in 5 days.";
        
        string subString = "in";
       
        Console.WriteLine(Regex.Matches(text,subString, RegexOptions.IgnoreCase).Count);
    }
}

