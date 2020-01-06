using System;
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
        public double Average;
        public double High;
        public double Low;
        public char Letter;
    }
}
