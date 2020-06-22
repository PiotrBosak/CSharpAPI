using System;

namespace ApdbTest2.Exceptions
{
    public class NoSuchCarException : Exception
    {
        public NoSuchCarException(string message) : base(message)
        
        {
            
        }

        public NoSuchCarException()
        {
            
        }

        public NoSuchCarException(string message, Exception exception) :base(message,exception)
        {
            
        }
    }
}