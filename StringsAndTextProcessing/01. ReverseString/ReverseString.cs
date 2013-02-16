using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ReverseString
{
    static void Main()
    {
        Console.Write("Please enter text:");
        string text = Console.ReadLine();
        char[] reversed = text.ToCharArray();
        Array.Reverse(reversed);

        Console.Write("The reversed text is:");
       
        Console.Write(reversed);
        Console.WriteLine();
    }
}


