using System;

namespace ApdbTest2.Exceptions

    {
        public class NoClientWithGivenIdException : Exception
        {
            public NoClientWithGivenIdException(string message) : base(message)
        
            {
            
            }

            public NoClientWithGivenIdException()
            {
            
            }

            public NoClientWithGivenIdException(string message, Exception exception) :base(message,exception)
            {
            
            }
        }
    }
