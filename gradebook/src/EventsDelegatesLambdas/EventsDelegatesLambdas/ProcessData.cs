using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDelegatesLambdas
{
    public class ProcessData
    {
        public void Process(int x, int y, BusinesRulesDelegate del)
        {
            var result = del(x, y);
            Console.WriteLine(result);
        }

        public int ProcessFunc(int x, int y, Func<int, int, int> func)
        {
            var result = func(x, y);
            Console.WriteLine(result);
            return result;
        }

        public void ProcessAction(int x, int y, Action<int,int> action)
        {
            Console.WriteLine("Action has been done");
        }
    }
}
