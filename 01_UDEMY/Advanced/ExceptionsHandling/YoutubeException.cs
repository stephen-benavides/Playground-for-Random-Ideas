using System;

namespace Advanced.ExceptionsHandling
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message, Exception innerException) : base(message, innerException)
        {
            
        }

        public YoutubeException(string message) : base(message)
        {
            
        }
    }
}