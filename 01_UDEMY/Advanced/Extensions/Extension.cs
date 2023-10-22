using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Extensions
{
    public static class  Extension
    {
        public static string Shorten(this string phrase, int numberOfWords)
        {
            if (phrase == null || phrase.Equals(""))
                throw new ArgumentNullException("It is empty");


            var phraseSizeArray = phrase.Split(' ');


            if (phraseSizeArray.Length > numberOfWords)
                return string.Join(" ", phraseSizeArray.Take(numberOfWords))+"...";
            
            return phrase;
        }
    }
}
