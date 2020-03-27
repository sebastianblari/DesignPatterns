using SocialSecurityValidator.Business.Exceptions;
using SocialSecurityValidator.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialSecurityValidator.Business.Handlers.UserValidation
{
    public class AgeValidatorHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if(user.Age < 18)
            {
                throw new UserValidationException("You have to be 18 years or older");
            }
            base.Handle(user);
        }
    }
}
