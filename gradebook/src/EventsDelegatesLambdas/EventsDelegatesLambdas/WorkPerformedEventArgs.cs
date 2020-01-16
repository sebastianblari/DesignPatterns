using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDelegatesLambdas
{
    public class WorkPerformedEventArgs : System.EventArgs
    {
        public WorkPerformedEventArgs(int hours, WorkType worktype)
        {
            Hours = hours;
            WorkType = worktype;
        }
        public int Hours { set; get; }
        public WorkType WorkType { set; get; }

    }
}
