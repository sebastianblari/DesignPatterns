using System;
using System.Collections.Generic;

namespace Gradebook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public class InMemoryBook : Book
    {
        public InMemoryBook(string name) : base(name)
        {
            result = new Statistics();
            grades = new List<double>();
            Name = name;
        }

        public override void AddGrade(double grade)
        {
            if(0.0 <= grade && grade <= 100)
            {
                this.grades.Add(grade);
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

        public override void AddGrade(char letter)
        {
            if ((letter != 'A') || (letter != 'B') || (letter != 'C') || (letter != 'D'))
            {
                switch (letter)
                {
                    case 'A':
                        this.AddGrade(90);
                        break;
                    case 'B':
                        this.AddGrade(80);
                        break;
                    case 'C':
                        this.AddGrade(70);
                        break;
                    case 'D':
                        this.AddGrade(60);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                throw new ArgumentException($"Invalid { nameof(letter) }");
            }
        }

        public Statistics GetStatistics()
        {
            foreach (var grade in this.grades)
            {
                result.Average += grade;
                result.High = Math.Max(result.High, grade);
                result.Low = Math.Min(result.Low, grade);
            }
            result.Average = result.Average / this.grades.Count;

            switch (result.Average)
            {
                case var letter when letter >= 90.0:
                    result.Letter = 'A';
                    break;
                case var letter when letter >= 80.0:
                    result.Letter = 'B';
                    break;
                case var letter when letter >= 70.0:
                    result.Letter = 'C';
                    break;
                case var letter when letter >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }


            Console.WriteLine($"{Name}'s average grade is: {result.Average}");
            Console.WriteLine($"{Name}'s highest grade is: {result.High}");
            Console.WriteLine($"{Name}'s lowest grade is: {result.Low}");
            Console.WriteLine($"{Name}'s average grade is: {result.Letter}");
            return result;
        }

        public event GradeAddedDelegate GradeAdded;

        private List<double> grades;
        public Statistics result;
    }
}
