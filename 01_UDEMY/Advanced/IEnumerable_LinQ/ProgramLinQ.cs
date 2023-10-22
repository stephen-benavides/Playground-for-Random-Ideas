using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.IEnumerable_LinQ
{
    class ProgramLinQ
    {
        public static void MainProgram(string[] args)
        {
            IEnumerable<int> myList = new List<int>() { 1, 2, 3, 4 };


            var result = myList
                .Where(n => n == 4)
                .Select(n => n);


            foreach (var i in result)
            {
                Console.WriteLine(i);
            }


        }
    }
}
