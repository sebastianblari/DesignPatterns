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

        public override void GetStatistics() { }

        public override event GradeAddedDelegate GradeAdded;

        
    }
}
