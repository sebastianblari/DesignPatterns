using System;
namespace attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DefaultColorAttribute : Attribute
    {
        public DefaultColorAttribute()
        {
            
        }

        public ConsoleColor Color { get; set; } = ConsoleColor.Yellow;   
    }
}
