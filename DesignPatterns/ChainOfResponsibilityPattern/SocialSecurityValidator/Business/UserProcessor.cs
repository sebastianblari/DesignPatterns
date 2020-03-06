using SocialSecurityValidator.Business.Exceptions;
using SocialSecurityValidator.Business.Handlers.UserValidation;
using SocialSecurityValidator.Business.Models;
using SocialSecurityValidator.Business.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialSecurityValidator.Business
{
    public class UserProcessor
    {

        public bool Register(User user)
        {
            try
            {
                var handler = new SocialSecurityNumberValidatorHandler();
                handler.SetNext(new AgeValidatorHandler())
                    .SetNext(new NameValidatorHandler())
                    .SetNext(new CitizenRegionValidatorHandler());
            }
            catch (UserValidationException ex)
            {
                return false;
            }
            return true;
        }
    }
}
