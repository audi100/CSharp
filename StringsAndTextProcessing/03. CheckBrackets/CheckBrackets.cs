using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CheckBrackets
{
    static void Main()
    {
        //string correct = "((a+b)/5-d)";
        //string incorrect = ")(a+b))";
        Console.WriteLine("Please enter expression with brackets:");
        string expression = Console.ReadLine();
        int countBrackets = 0;

        foreach (char item in expression)
        {
            if (item=='(')
            {
                countBrackets++; 
            }
            if (item==')')
            {
                countBrackets--; 
            }
            if (countBrackets<0)
            {
                Console.WriteLine("The brackets are NOT put correctly.");
                return;
            }
        }
        Console.WriteLine("The brackets are put correctly.");
    }
}

