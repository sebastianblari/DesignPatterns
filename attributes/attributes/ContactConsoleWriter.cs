using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace attributes
{
    public class ContactConsoleWriter
    {
        private readonly Contact _contact;
        private ConsoleColor _color;

        public ContactConsoleWriter(Contact contact)
        {
            _contact = contact;
        }
        public void Write()
        {
            UseDefaultColor();
            WriteFirstName();
            WriteAge();
        }

        private void UseDefaultColor()
        {
            //En este caso se liga la clase con el atributo
            DefaultColorAttribute defaultColorAttribute = (DefaultColorAttribute)Attribute.GetCustomAttribute(typeof(Contact), typeof(DefaultColorAttribute));
            if(defaultColorAttribute != null)
            {
                Console.ForegroundColor = defaultColorAttribute.Color;
            }
            
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
            // Se usa reflexion para obtener el objeto PropertyInfo que contiene la informacion sobre las propiedad FirstName de mi clase
            // Basicamente se obtiene la infromacion de la propiedad para pueda ser posteriormente ligada con el Atributo
            PropertyInfo firstNameProperty = typeof(Contact).GetProperty(nameof(Contact.FirstName));

            // Se liga el atributo con la propiedad
            DisplayAttribute firstNameDisplayAttribute = (DisplayAttribute)Attribute.GetCustomAttribute(firstNameProperty, typeof(DisplayAttribute));

            PropertyInfo indentProperty = typeof(Contact).GetProperty(nameof(Contact.FirstName));
            IndentAttribute[] indentAttributes = (IndentAttribute[])Attribute.GetCustomAttributes(indentProperty, typeof(IndentAttribute));



            PreserveForegroundColor();

            StringBuilder sb = new StringBuilder();

            if(firstNameDisplayAttribute != null)
            {
                Console.ForegroundColor = firstNameDisplayAttribute.Color;
                sb.Append(firstNameDisplayAttribute.Label);
            }

            if (_contact != null)
            {
                sb.AppendLine(_contact.FirstName); 
            }

            if (indentAttributes != null)
            {
                foreach(var indentAttribute in indentAttributes)
                {
                    sb.Append(new String(' ', 4));
                }
                
            }

            Console.Write(sb);
            RestoreForegroundColor();
        }

        private void PreserveForegroundColor()
        {
            _color = Console.ForegroundColor;
        }

        private void RestoreForegroundColor()
        {
            Console.ForegroundColor = _color;
        }
    }
}
