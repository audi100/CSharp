using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class School
{
    public string Name { get; set; }
    public List<ClassOfStudents> Classes {get;set;}

    public School(string name, List<ClassOfStudents> classes)
    {
        this.Name = name;
        this.Classes = new List<ClassOfStudents>();
    }
    public void AddClass(ClassOfStudents @class)
    {
        this.Classes.Add(@class);
    }
    public void RemoveClass(ClassOfStudents @class)
    {
        this.Classes.Remove(@class);
    }
}

