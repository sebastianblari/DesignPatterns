using System;
namespace Gradebook
{
    public abstract class Book : NamedObject
    {
        public Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
        public abstract void AddGrade(char letter);
    }
}
