using SocialSecurityValidator.Business.Exceptions;
using SocialSecurityValidator.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialSecurityValidator.Business.Handlers.UserValidation
{
    public class NameValidatorHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if(user.Name.Length < 1)
            {
                throw new UserValidationException("Your name is unlikely this short");
            }
            base.Handle(user);
        }
    }
}
