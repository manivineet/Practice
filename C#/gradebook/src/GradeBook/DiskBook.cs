using System;
using System.Collections.Generic;
using System.IO;

namespace GradeBook
{

    public class DiskBook : Book
    {
        List<double> grades;
        public DiskBook(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;

        }


        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatistics()
        {

            var result = new Statistics();
           
            if (grades.Count > 0)
            {
                result = result.GetGrades(grades);
            }
            else
                Console.WriteLine("List is empty");
                
            return result;

        }

        public override event GradeAddedDelegate GradeAdded;


    }
}