//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 5	0	1

using System;
using System.Collections.Generic;
using System.Text;

class Polynomials
{
    static void Main()
    {
        decimal[] poli1 = { 0, 1, 4, 1 };//x^3+4x^2+x+0
        decimal[] poli2 = { 9, 8, 9 };//9x^2+8x+9
        Console.WriteLine("First polinomial is:");
        Console.WriteLine(PrintPoli(poli1));
        Console.WriteLine("Second polinomial is:");
        Console.WriteLine(PrintPoli(poli2));
        Console.WriteLine("The sum - result is:");
        Console.WriteLine(PrintPoli(AddPolinomials(poli1, poli2)));
        Console.WriteLine();
    }

    static string PrintPoli(decimal[] polynomial)
    {
        StringBuilder returnString = new StringBuilder();

        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0)
            {
                returnString.Append(polynomial[i] > 0 ? " + " : " - ");
                returnString.Append(Math.Abs(polynomial[i]));
                if (i != 0)
                {
                    returnString.Append(i > 1 ? "x^" + i : "x");
                }
            }
        }

        if (returnString[1] != '-')
        {
            returnString.Remove(0, 3);
        }
        else
        {
            returnString.Remove(0, 1);
        }

        return returnString.ToString();
    }

    static decimal[] AddPolinomials(decimal[] poli1, decimal[] poli2)
    {
        int maxLen = Math.Max(poli1.Length, poli2.Length);
        decimal[] result=new decimal[maxLen];
        for (int i = 0; i < poli1.Length; i++)
        {
            result[i] = poli1[i];
        }
        for (int i = 0; i < poli2.Length; i++)
        {
            result[i] += poli2[i];
        }
        return result;
    }
}