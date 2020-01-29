using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace attributes
{
    [DebuggerDisplay("First Name={FirstName} and AgeInYears={AgeInYears}")]
    [DebuggerTypeProxy(typeof(ContactDebugDisplay))]
    public class Contact
    {
        public string FirstName { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int AgeInYears { get; set; }
    }
}
