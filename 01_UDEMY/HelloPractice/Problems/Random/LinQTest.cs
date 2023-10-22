using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Random
{
    public class LinQTest
    {
        private static ArrayList _list = new ArrayList(){1,2,3,4};
        private List<string> NamesList = new List<string>(){"Bob", "Carl", "Betsy", "Malinda"};
        private string[] NamesArray = new string[]{ "Bob", "Carl", "Betsy", "Malinda" };

        
        public void PrintList()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }

        public string PrintSpecificElement()
        {

            return _list.IndexOf(3).ToString();
        }

        /// <summary>
        /// Uses LinQ Fluent API, it is used with Collections
        /// </summary>
        public void PrintFluentApi()
        {
            NamesList.FindAll(n => n.Contains("B"))
                // .OrderBy(n => n)
                // .ToList()
                .ForEach(n => Console.WriteLine(n));
        }

        /// <summary>
        /// Uses Integrated Query, very limited, uses Array 
        /// </summary>
        public void PrintIntegratedQuery()
        {
            //selct * from NamesList where NamesList like ("B%")
            var result = from name in NamesArray where name.Contains("B") select name;


            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Similar to Fluent API, it is used on Array, uses same process 
        /// </summary>

        public void PrintLambdaLinQ()
        {
            foreach (var name in NamesArray.Where(n => n.Contains("B")))
            {
                Console.WriteLine(name);
            }
        }
    }
}
