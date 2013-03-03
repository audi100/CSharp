using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Student:Human
{
    private string uniqueClassNumber;
    public string UniqueClassNumber { get; set; }

    public Student(string name, string uniqueClassNumber)
        : base(name)
    {
        this.UniqueClassNumber = uniqueClassNumber;
    }
}

