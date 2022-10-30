using System;

namespace ReservaHotemBom.Entities.Exceptions
{
    class DomainExeptions : ApplicationException
    {
        public DomainExeptions(string message) : base(message)
        {

        }
    }
}
