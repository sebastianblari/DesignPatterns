using System;

namespace EventsDelegatesLambdas
{
    public class JobChangedArgs : EventArgs
    {
        public Job job { set; get; }
    }
}