using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Events
{
    class ProgramEvent
    {
        static void MainProgram(string[] args)
        {
            Encoder encoder = new Encoder(); // Publisher
            MailService mailService = new MailService(); //Subscriber

            encoder.VideoEncoded += mailService.MailServiceSubscriber;

            encoder.VideoEncode(new Video() { Title = "Any Movie" });

        }
    }
}
