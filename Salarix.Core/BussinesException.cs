using System;

namespace Salarix.Core
{
    public class BussinesException : Exception
    {
        public BussinesException(string message)
            : base(message)
        {
            
        }
    }
}
