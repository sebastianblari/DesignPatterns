using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace attributes
{
    public class ContactConsoleWriter
    {
        private readonly Contact _contact;
        public ContactConsoleWriter(Contact contact)
        {
            _contact = contact;
        }
        public void Write()
        {
            WriteFirstName();
            WriteAge();
        }
        //[Obsolete]
        [Obsolete("Write() will be removed in version 2.0")]
        //[Obsolete("Write() will be removed in version 2.0", true)]
        private void WriteAge()
        {
            OutputDebugInfo();
            Console.WriteLine(_contact.AgeInYears);
        }
        [Conditional("DEBUG")]
        private void OutputDebugInfo()
        {
            Console.WriteLine("***DEBUG MODE***" );
        }

        private void WriteFirstName()
        {
            Console.WriteLine(_contact.FirstName);
        }
    }
}
