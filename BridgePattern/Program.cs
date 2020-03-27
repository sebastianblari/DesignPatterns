using System;
using System.Collections.Generic;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var formatter = new StandardFormatter();
            var reverse = new ReverseFormatter();
            var faq = new FAQ(formatter);
            var documents = new List<Manuscript>();
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation.");
            documents.Add(faq);

            var book = new Book(reverse)
                       {
                           Title = "Lots of Patterns",
                           Author = "John Sonmez",
                           Text = "Blah blah blah..."
                       };
            documents.Add(book);

            var paper = new TermPaper(formatter)
                        {
                            Class = "Design Patterns",
                            Student = "Joe N00b",
                            Text = "Blah blah blah...",
                            References = "GOF"
                        };
            documents.Add(paper);

            foreach (var doc in documents)
            {
                doc.Print();
            }

            //Console.ReadKey();
        }
    }
}
