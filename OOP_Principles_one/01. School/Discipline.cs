using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Discipline
{
    private string name;
    private byte numberOfLectures;
    private byte numberOfExercises;
    private List<string> comments;

    public string Name { get; set; }
    public byte NumberOfLectures { get; set; }
    public byte NumberOfExercises { get; set; }
    public List<string> Comments { get;set;}

    
    public Discipline(string name, byte numberOfLectures, byte numberOfExercises)
    {
        this.Name = name;
        this.NumberOfLectures = numberOfLectures;
        this.NumberOfExercises = numberOfExercises;
    }
    public Discipline(string name, byte numberOfLectures, byte numberOfExercises, List<string>comments)
        :this(name, numberOfLectures, numberOfExercises)
    {
        this.Comments = new List<string>();
    }


}

