using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ClassOfStudents
{
    public string ClassIdentifier { get; set; }
    public List<Teacher> teachers{get;set;}
    public List<Student> students { get; set; }
    public List<string> Comments;

    public ClassOfStudents(string classIdentifier, List<Teacher> teachers, List<Student> students)
    {
        this.ClassIdentifier = classIdentifier;
        this.teachers = new List<Teacher>();
        this.students = new List<Student>();
    }
    public ClassOfStudents(string classIdentifier, List<Teacher> teachers, 
        List<Student> students, List<string> comments):this(classIdentifier, teachers,students)
    {      
        this.Comments = new List<string>();
    }
    public void AddStudent(Student student)
    {
        this.students.Add(student);
    }
    public void RemoveStudent(Student student)
    {
        this.students.Remove(student);
    }
    public void AddTeacher(Teacher teacher)
    {
        this.teachers.Add(teacher);
    }
    public void RemoveTeacher(Teacher teacher)
    {
        this.teachers.Remove(teacher);
    }
    public void AddComment(string comment)
    {
        this.Comments.Add(comment);
    }
    public void RemoveComment(string comment)
    {
        this.Comments.Remove(comment);
    }
}

