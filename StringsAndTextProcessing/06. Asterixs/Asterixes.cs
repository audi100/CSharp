using System;
using System.Text;

class Asterixes
{
    static void Main()
    {
        Console.Write("Please enter string with no more than 20 characters!");
        string text = Console.ReadLine();

        if (text.Length > 20)
        {
            Console.WriteLine("No more than 20 characters, please!");
        }
        else
        {
            StringBuilder twentyChars = new StringBuilder();
            twentyChars.Append(text);
            while (twentyChars.Length < 20)
            {
                twentyChars.Append('*');
            }
            Console.WriteLine("The changed text is:{0}",twentyChars.ToString());
        }
    }
}

