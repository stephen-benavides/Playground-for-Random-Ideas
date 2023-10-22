using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Udemy.Intermediate
{
    class FieldsPractice
    {
        // Always initialize lists or any other fields in an empty list 
        public int id;
        public string Name;
        // You can initialize to empty list, be careful to always use the same approach always
        public readonly List<String> Orders = new List<string>();


        public void Promote()
        {
            //
            //Orders = new List<string>();
        }
    }
}
