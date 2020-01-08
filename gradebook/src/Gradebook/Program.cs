using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook sebastiansBook = new DiskBook("Sebastian's Book");
            sebastiansBook.GradeAdded += OnGradeAdded;
            EnterGrades(sebastiansBook);
            sebastiansBook.GetStatistics();
            //Console.WriteLine($"{sebastiansBook.Name}'s average grade is: {sebastiansBook.result.Average}");
        }

        private static void EnterGrades(IBook sebastiansBook)
        {
            while (true)
            {
                Console.WriteLine($"Enter a grade or press 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                else
                {
                    //var grade = double.Parse(input);
                    try
                    {
                        var grade = double.Parse(input);
                        sebastiansBook.AddGrade(grade);
                    }
                    catch (FormatException)
                    {
                        try
                        {
                            var letter = char.Parse(input);
                            sebastiansBook.AddGrade(letter);
                        }
                        catch (FormatException)
                        {
                            continue;
                        }

                    }
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("A grade was added");
        }
    }  
}
