using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class Animal
{
    private string name;
    private string sex;
    private byte age;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (this.name != String.Empty)
            {
                this.name = value;
            }
        }
    }
    public string Sex
    {
        get
        {
            return this.sex;
        }
        set
        {
            if (this.sex != String.Empty)
            {
                this.sex = value;
            }
        }
    }
    public byte Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (this.age >= 0 && this.age <= 110)
            {
                this.age = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Age should be between 0 and 110 years!");
            }
        }
    }
    public Animal()
    {
        this.Name = "Unnamed";
        this.Sex = "Unknown";
        this.Age = 0;
    }

    public Animal(string name, string sex, byte age)
    {
        this.Name = name;
        this.Sex = sex;
        this.Age = age;
    }
    public static decimal CalculateAverage(Animal[] animalArr)
    {
        decimal sum = 0;
        decimal count = 0;
        foreach (var animal in animalArr)
        {
            sum += animal.Age;
            count++;
        }
    return sum / count;
    }
}

