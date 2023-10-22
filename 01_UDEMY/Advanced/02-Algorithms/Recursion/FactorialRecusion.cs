using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._02_Algorithms
{
    class FactorialRecusion
    {

        public static void MainCaller(string[] args)
        {
            Console.WriteLine(FindFactorialIterative(10));
            Console.WriteLine(FindFactorialRecursive(10));
        }

        public static int FindFactorialRecursive(int number)
        {
            Console.WriteLine(number);
            if (number <= 1)
                return 1;
            return number * FindFactorialRecursive(number - 1);
            /*
             * 5 * 4!
             * 5 * 4 * 3!
             * 5 * 4 * 3 * 2!
             * 5 * 4 * 3 * 2 * 1 ==> when num == 1 then return 1
             * when it hits 1 then it bubbles up and it becomes 1 -> 2 ->3 -> 4 ->5
             */
            // Always think on when the scenario is going to stop and what the final
            // result of the recursion is going to look like before implementing any recursion 
            /*
             *In this case our final number is going to be 1, think on what happens after
             * you get to 1 to return the max value 
             *
             */
        }

        public static int FindFactorialIterative(int number)
        {
            int result = 1;
            while (number > 0)
            {
                result *= number;
                number--;
            }

            return result;
        }
    }
}
