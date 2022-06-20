using System;
using ContaBancariaSimples.Entities;

namespace ContaBancariaSimples.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
