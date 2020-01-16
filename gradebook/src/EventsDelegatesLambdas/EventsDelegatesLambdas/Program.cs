using System;

namespace EventsDelegatesLambdas
{
    public delegate int BusinesRulesDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            /*
            Agregar un event EventHandler usando la nomenclatura completa
            */
            //worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);

            /*
            Agregar un event EventHandler usando inferencia de delegados
            */
            //worker.WorkPerformed += Worker_WorkPerformed;
            //worker.WorkCompleted += Worker_WorkCompleted;

            /*
             * Agregando un metodo anonimo
             */
            //worker.WorkPerformed += delegate (object sender, WorkPerformedEventArgs e)
            //{
            //    Console.WriteLine($"Hours worked: { e.Hours} {e.WorkType}");
            //};
            //worker.WorkCompleted += delegate (object sender, EventArgs e)
            //{
            //    Console.WriteLine($"Work completed");
            //};

            /*
             * Usando Lambdas
             */
            //worker.WorkPerformed += (s, e) => Console.WriteLine($"Hours worked: { e.Hours} {e.WorkType}");
            //worker.WorkCompleted += (s, e) => Console.WriteLine($"Work completed");


            //worker.DoWork(8, WorkType.GenerateReports);

            
            var data = new ProcessData();
            var addDel = new BusinesRulesDelegate((x, y) => x + y);
            BusinesRulesDelegate multiplyDel = (x, y) => x * y;
            BusinesRulesDelegate substractDel = (x, y) => x - y;
            BusinesRulesDelegate divideDel = (x, y) => x / y;
            data.Process(2, 3, addDel);
            data.Process(2, 3, multiplyDel);

            Action<int, int> actionSum = (x, y) => Console.WriteLine(x + y);
            Action<int, int> actionMultiply = (x, y) => Console.WriteLine(x * y);
            data.ProcessAction(5, 6, actionSum);
            data.ProcessAction(5, 6, actionMultiply);

            Func<int, int, int> funcSum = (x, y) => x + y;
            Func<int, int, int> funcMultiply = (x, y) => x * y;

            var sum = data.ProcessFunc(5, 6, funcSum);
            var mult = data.ProcessFunc(5, 6, funcMultiply);

        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"Hours worked: { e.Hours} {e.WorkType}");
        }
        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine($"Work completed");
        }

    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
