using SocialSecurityValidator.Business.Exceptions;
using SocialSecurityValidator.Business.Models;
using SocialSecurityValidator.Business.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialSecurityValidator.Business.Handlers.UserValidation
{
    public class SocialSecurityNumberValidatorHandler : Handler<User>
    {
        private SocialSecurityNumberValidator socialSecurityNumberValidator = new SocialSecurityNumberValidator();
        public override void Handle(User request)
        {
            if(!socialSecurityNumberValidator.Validate(request.SocialSecurityNumber,request.CitizenshipRegion))
            {
                throw new UserValidationException("Social security number could not be validated");
            }
            base.Handle(request);
        }
    }
}
