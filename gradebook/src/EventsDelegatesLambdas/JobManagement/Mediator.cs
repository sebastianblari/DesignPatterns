using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDelegatesLambdas
{
    public sealed class Mediator // sealed en una clase impide que otras clases puedan derivar de ella
    {
        private static readonly Mediator _Instance = new Mediator(); // singleton
        private Mediator()
        {

        }
        public static Mediator GetInstance()
        {
            return _Instance;
        }

        public event EventHandler<JobChangedArgs> JobChanged;
        public void OnJobChanged(object sender, Job job)
        {
            var jobChangeDelegate = JobChanged as EventHandler<JobChangedArgs>;
            if (jobChangeDelegate!= null)
            {
                JobChanged(sender, new JobChangedArgs { job = job });
            }
        }
    }
}