using System;
using System.Collections.Generic;
namespace Gradebook
{
    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);
        public abstract void AddGrade(char letter);
        public abstract void GetStatistics();
        public Statistics result;
        public List<double> grades;
    }
}
