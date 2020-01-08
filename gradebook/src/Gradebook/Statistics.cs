using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Statistics
    {
        public Statistics()
        {
            this.Average = 0.0;
            this.High = Double.MinValue;
            this.Low = Double.MaxValue;
        
        }

        public void GetStatistics(List<double> grades)
        {
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
                Average += grade;
                High = Math.Max(High, grade);
                Low = Math.Min(Low, grade);
            }
            Average = Average / grades.Count;

            switch (Average)
            {
                case var letter when letter >= 90.0:
                    Letter = 'A';
                    break;
                case var letter when letter >= 80.0:
                    Letter = 'B';
                    break;
                case var letter when letter >= 70.0:
                    Letter = 'C';
                    break;
                case var letter when letter >= 60.0:
                    Letter = 'D';
                    break;
                default:
                    Letter = 'F';
                    break;
            }
            Console.WriteLine($"The average grade is: {Average}");
            Console.WriteLine($"The lowest grade is: {Low}");
            Console.WriteLine($"The highest grade is: {High}");
        }

        public double Average;
        public double High;
        public double Low;
        public char Letter;
    }
}
