using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Student:Human
{
    private byte grade;

    public byte Grade { get; set; }

    public Student(string firstName, string lastName, byte grade)
        : base(firstName, lastName)
    {
        this.Grade = grade;
    }
}

