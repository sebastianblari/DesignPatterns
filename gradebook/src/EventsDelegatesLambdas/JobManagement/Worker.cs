using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDelegatesLambdas
{   
    /*
     * public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e);
     */
    
    public class Worker
    {
        /*
        public event WorkPerformedHandler WorkPerformed;
        */
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }

        protected void OnWorkPerformed(int hours, WorkType workType)
        {
            /*
             * var del = WorkPerformed as WorkPerformedHandler;
             */
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if (WorkPerformed != null)
            {
                del(this, new WorkPerformedEventArgs(hours,workType));
            }
        }

        protected void OnWorkCompleted()
        {
            var del = WorkCompleted as EventHandler;
            if (WorkCompleted != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}
