using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Extensions
{
    class ExtensionProgram
    {
        public static void MainCaller(string[] args)
        {
            // Write somehing that creates something like "this is the phrase..." after the 4th phrase using extensions 

            try
            {
                var phrase = "Another thing";
                Console.WriteLine(phrase.Shorten(1));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }
    }
}
