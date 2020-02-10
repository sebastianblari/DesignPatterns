using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace attributes
{
    [DebuggerDisplay("First Name={FirstName} and AgeInYears={AgeInYears}")]
    [DebuggerTypeProxy(typeof(ContactDebugDisplay))]
    [DefaultColor(Color = ConsoleColor.Magenta)]
    public class Contact
    {
        //Si el nombre de la clase creada para mi atributo termina con Attribute a la hora de usarlo, se puede reducir
        //[Display("First Name: ", ConsoleColor.Cyan)]
        [DisplayAttribute("First Name: ",ConsoleColor.Cyan)]
        [IndentAttribute]
        [IndentAttribute]
        [IndentAttribute]
        public string FirstName { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int AgeInYears { get; set; }
    }
}
