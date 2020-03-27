using System;
using System.Collections.Generic;
using System.Text;

namespace SocialSecurityValidator.Business.Exceptions
{
    public class UserValidationException : Exception
    {
        public UserValidationException(string message) : base(message)
        {
        }
    }
}