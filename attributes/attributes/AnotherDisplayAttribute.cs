using System;
namespace attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AnotherDisplayAttribute : Attribute
    {
        public AnotherDisplayAttribute(string label, ConsoleColor color = ConsoleColor.Yellow)
        {
            Label = label ?? throw new ArgumentNullException(nameof(label));
            Color = color;
        }
        public string Label { get; }
        public ConsoleColor Color { get; }
    }
}
