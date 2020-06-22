using System;

namespace ApdbTest2.Exceptions
{
    public class CityWasNotAddedException : Exception
    {
        public CityWasNotAddedException(string message) : base(message)
        
        {
            
        }

        public CityWasNotAddedException()
        {
            
        }

        public CityWasNotAddedException(string message, Exception exception) :base(message,exception)
        {
            
        }
    }
}