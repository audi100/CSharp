using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class EncodeAlg
{
    static void Main()
    {
        string text = "Blue sky and shiny sun are really great!";//Console.ReadLine();
        string key = "980y";
        Console.WriteLine("The encoded text is:");
        Console.WriteLine(Encode(text,key));
        Console.WriteLine();
        Console.WriteLine("The decoded text is:");
        Console.WriteLine(Decode(Encode(text, key),key));
        Console.WriteLine();
    }
    static string Encode(string text, string key)
    {
        StringBuilder encoded = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            encoded.Append((char)(text[i] ^ key[i % key.Length])); 
        }
        return encoded.ToString();
    }
    static string Decode(string text, string key)
    {
        return Encode(text, key);
    }
}

