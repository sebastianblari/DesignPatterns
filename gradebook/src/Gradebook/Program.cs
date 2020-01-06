using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book sebastiansBook = new Book("Sebastian's Book");
            sebastiansBook.GradeAdded += OnGradeAdded;
            while (true)
            {
                Console.WriteLine($"Enter a grade or press 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q")
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
                        catch(FormatException)
                        {
                            continue;
                        }
                        
                    }
                }
            }
            sebastiansBook.GetStatistics();
            Console.WriteLine($"{sebastiansBook.Name}'s average grade is: {sebastiansBook.result.Average}");
        }

        static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("A grade was added");
        }
    }  
}
