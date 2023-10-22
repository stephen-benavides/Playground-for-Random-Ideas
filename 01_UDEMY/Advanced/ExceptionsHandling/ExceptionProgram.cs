using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.ExceptionsHandling
{
    class ExceptionProgram
    {
        public static void MainProgram(string[] args)
        {
            try
            {
                var api = new YoutubeVideos();
                api.GetVideos("mosh");
            }
            /*catch (YoutubeException e)
            {
                Console.WriteLine(e.Message);
            }*/
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
