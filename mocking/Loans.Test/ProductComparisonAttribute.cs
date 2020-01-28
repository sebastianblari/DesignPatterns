using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Loans.Tests
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class ProductComparisonAttribute : CategoryAttribute
    {
    }
}
