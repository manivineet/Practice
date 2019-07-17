using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Statistics
    {

        public double Average;

        public double High;

        public double Low;

        public double Sum;

        public int Count;


        public Statistics()
        {
            Count = 0;
            Average = 0.0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }


        public char Letter;

        public Statistics GetGrades(List<double> grades)
        {

            var result = new Statistics();

            //highest Grade
            foreach (var grade in grades)
            {
                High = Math.Max(grade, High);
            }

            //lowest Grade
            foreach (var grade in grades)
            {
                Low = Math.Min(Low, grade);
            }

            foreach (var grade in grades)
            {
                result.Average += grade;
            }

            //average
            result.Average /= grades.Count;

            result.Letter = GetLetter(result.Average);

            return result;

        }

        private char GetLetter(double average)
        {
            switch (average)
            {
                case var d when d >= 90.0:
                    return 'A';

                case var d when d >= 80.0:
                    return 'B';

                case var d when d >= 70.0:
                    return 'C';

                default:
                    return 'D';

            }
        }
    }


}