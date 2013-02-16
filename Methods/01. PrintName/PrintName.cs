//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method.

using System;

class PrintName
{
    static void Main()
    {
        Console.WriteLine("Please enter your name.");       
        GreetMe(Console.ReadLine());
    }
    static void GreetMe(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}

