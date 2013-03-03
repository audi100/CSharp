using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Human
{
    private string name;
    private List<string> comment;
    public string Name { get; set; }
    public List<string> Comment;
    

    protected Human(string name)
    {
        this.Name = name;
    }
    protected Human(string name, List<string> comments):this(name)
    {
        this.Comment=new List<string>();
    }
}

