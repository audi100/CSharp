using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Teacher:Human
{

    public List<Discipline> Disciplines{get;set;}


    public Teacher(string name, List<Discipline> disciplines):base(name)
    {
        this.Disciplines = new List<Discipline>();
    }
    public void AddDiscipline(Discipline discipline)
    {
        this.Disciplines.Add(discipline);
    }
    public void RemoveDiscipline(Discipline discipline)
    {
        this.Disciplines.Remove(discipline);
    }
}

