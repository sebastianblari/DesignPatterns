using SocialSecurityValidator.Business;
using SocialSecurityValidator.Business.Models;
using System;
using System.Globalization;

namespace SocialSecurityValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Filip Ekberg",
                "870101XXXX",
                new RegionInfo("NO"),
                new DateTimeOffset(1987, 01, 29, 00, 00, 00, TimeSpan.FromHours(2)));


            Console.WriteLine(user.Age);
            var processor = new UserProcessor();

            var result = processor.Register(user);

            Console.WriteLine(result);
        }
    }
}
