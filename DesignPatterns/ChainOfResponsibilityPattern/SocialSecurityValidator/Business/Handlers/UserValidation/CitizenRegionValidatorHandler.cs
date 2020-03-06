using SocialSecurityValidator.Business.Exceptions;
using SocialSecurityValidator.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialSecurityValidator.Business.Handlers.UserValidation
{
    public class CitizenRegionValidatorHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (user.CitizenshipRegion.TwoLetterISORegionName == "NO")
            {
                throw new UserValidationException("We currently do not support Norwegians");
            }
            base.Handle(user);
        }
    }
}
