using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloPractice.Problems.Udemy.Beginners
{
    class ArrayVarargs
    {

        /*static void Main(string[] args)
        {
            int[] val = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(addArr(1, 2, 3, 4));
        }*/

        public static int addArr(params int[] num) // Same as Java int ... nums 
        {
            int a = 0;
            foreach (var t in num)
                a += t;

            return a;
        }

    }


}
