using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            if(0.0 <= grade && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public void AddGrade(char letter)
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

        public double Average()
        {
            double l_average = 0.0;
            foreach(var grade in this.grades)
            {
                l_average += grade;
            }
            this.average = l_average / this.grades.Count;
            return average;
        }

        public double Highest()
        {
            this.highest = Double.MinValue;
            foreach (var grade in this.grades)
            {
                this.highest = Math.Max(this.highest, grade);
            }
            return this.highest;
        }

        public double Lowest()
        {
            this.lowest = Double.MaxValue;
            foreach (var grade in this.grades)
            {
                this.lowest = Math.Min(this.lowest, grade);
            }
            return this.lowest;
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = this.Average();
            result.High = this.Highest();
            result.Low = this.Lowest();
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


            Console.WriteLine($"{name}'s average grade is: {this.Average()}");
            Console.WriteLine($"{name}'s highest grade is: {this.Highest()}");
            Console.WriteLine($"{name}'s lowest grade is: {this.Lowest()}");
            return result;
        }

        private List<double> grades;
        private double average;
        private string name;
        private double highest;
        private double lowest;
    }
}
