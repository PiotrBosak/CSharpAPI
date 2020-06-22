using System;

namespace ApdbTest2.Exceptions
{
    public class InvalidClientDataException : Exception
    {
        public InvalidClientDataException(string message) : base(message)
        
        {
            
        }

        public InvalidClientDataException()
        {
            
        }

        public InvalidClientDataException(string message, Exception exception) :base(message,exception)
        {
            
        }
    }
}