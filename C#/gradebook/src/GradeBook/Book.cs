using System;
using System.Collections.Generic;

namespace GradeBook
{

    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name 
        {get; set;}
    }

     public interface IBook
     {
         void AddGrade(double grade);
         Statistics GetStatistics();
         string Name {get;}
         event GradeAddedDelegate GradeAdded;
    }

    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);

        public virtual Statistics GetStatistics()
        {

                throw new NotImplementedException();
        }

        public virtual event GradeAddedDelegate GradeAdded;
    }



    public class InMemoryBook :  Book
    {

        List<double> grades;

        public const string CATEGORY = "Science";
        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public override void AddGrade(double grade)
        {
            if (grade <= 100 & grade >= 0)
            {
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public override event GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
           
            if (grades.Count > 0)
            {
                result = result.GetGrades(grades);
            }
            else
                Console.WriteLine("Grades List is empty");

            return result;

        }
    }
}