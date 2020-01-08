using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public interface IBook
    {
        void AddGrade(double grade);
        void AddGrade(char letter);
        void GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }
}
