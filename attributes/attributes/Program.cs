using System;

namespace attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sarah = new Contact
            {
                FirstName = "Sarah",
                AgeInYears = 42
            };

            var sarahWriter = new ContactConsoleWriter(sarah);
            sarahWriter.Write();
        }


    }
}
