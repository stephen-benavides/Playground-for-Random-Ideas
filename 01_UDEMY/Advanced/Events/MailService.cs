using System;

namespace Advanced.Events
{
    // Subscriber 
    class MailService
    {
        public void MailServiceSubscriber(Object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending to the MailService Class: {0}", args.Video.Title);
        }
    }
}