using System;

namespace _04_ContaBancariaExercicioFixacao
{
    class DomainExeptions : ApplicationException
    {
        public DomainExeptions(string message) : base(message)
        {

        }
    }
}
