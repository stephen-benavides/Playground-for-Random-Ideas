using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.Nullable
{
    class NullableProgram
    {
        public static void MainProgram(string[] args)
        {
            // Long Way
            Nullable<DateTime> date4 = null;

            //Short Way 
            DateTime? date = DateTime.Now;
            DateTime? date3 = null;

            //Nullable Coallescense Operator
            DateTime date2 = date3 ?? date3.GetValueOrDefault();

            Console.WriteLine(date2);
        }
    }
}
