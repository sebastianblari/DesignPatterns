using System;
namespace attributes
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)]
    public class IndentAttribute : Attribute
    {
        public IndentAttribute()
        {
        }
    }
}
