using System;

class Person
{
    public string Name { get; set; }
    public byte? Age { get; set; }

    public Person(string name):this(name,null)
    {
        
    }
    
    public Person(string name, byte? age)
    {
        if (name==string.Empty||name==null||name.Length<2)
        {
            throw new ArgumentOutOfRangeException("Invalid name. It should be at least three characters long.");
        }
        else
        {
            this.Name = name;            
        }
        if (age<0||age>125)
        {
            throw new ArgumentOutOfRangeException("Invalid age. It should be in the range between 0 and 124.");            
        }
        else
        {
            this.Age = age;
        }
      
    }
    public override string ToString()
    {

        return string.Format("Name of the person:{0,15} Age:{1,3}", this.Name, 
            ((this.Age.ToString()!="")?this.Age.ToString():"Not Specified"));
    }

}

