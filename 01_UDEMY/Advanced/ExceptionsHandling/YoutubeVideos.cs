using System;

namespace Advanced.ExceptionsHandling
{
    public class YoutubeVideos
    {
        public string name { get; set; }   
        public string video { get; set; }

        public void GetVideos(string name)
        {
            if (name == this.name)
                Console.WriteLine($"Video is: {this.video}");
            throw new YoutubeException("No Youtube Video Found");
        }
    }
}