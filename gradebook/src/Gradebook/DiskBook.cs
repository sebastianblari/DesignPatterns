using System;
using System.Collections.Generic;using System.IO;
using System.Text;

namespace Gradebook
{
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
            result = new Statistics();
            grades = new List<double>();
            Name = name;
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            /*var writer = File.AppendText($"C:\\Users\\sblancoa\\Documents\\GitHub\\CSharpLearning\\gradebook\\src\\Gradebook\\{this.Name}.txt");
            Console.WriteLine($"Introduced grade: {grade}");
            writer.WriteLine(grade);
            writer.Close();*/
            using (var writer = File.AppendText($"C:\\Users\\sblancoa\\Documents\\GitHub\\CSharpLearning\\gradebook\\src\\Gradebook\\{this.Name}.txt"))
            {
                writer.WriteLine(grade);
                grades.Add(grade);
            } 
        }

        public override void AddGrade(char letter)
        {
            throw new NotImplementedException();
        }

        public override void GetStatistics()
        {
            result.GetStatistics(grades);
        }

        
    }

}
