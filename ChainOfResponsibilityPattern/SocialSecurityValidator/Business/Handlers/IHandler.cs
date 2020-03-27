using System;
using System.Collections.Generic;
using System.Text;

namespace SocialSecurityValidator.Business.Handlers
{
    public interface IHandler<T> where T: class
    {
        IHandler<T> SetNext(IHandler<T> next);
        void Handle(T request);
    }
}
