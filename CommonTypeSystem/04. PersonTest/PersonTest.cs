//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString()
//to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PersonTest
{
    static void Main()
    {
        Person Gerginov = new Person("Georgi Gerginov", 23);
        Person Ivanov = new Person("Petar Feodorov");
        Console.WriteLine(Gerginov);
        Console.WriteLine(Ivanov);
    }
}

