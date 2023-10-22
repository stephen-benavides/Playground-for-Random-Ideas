using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._02_Algorithms.Recursion
{
    class FibonnachiRecursion
    {
        public static void MainCaller(string[] args)
        {
            Console.WriteLine(FibonacciIterativeRecursive(2));

        }
        /// <summary>
        /// Return fibonacchi sequence 
        /// </summary>
        /// <param name="n">Index of the number in the sequence</param>
        public static int FibonacciIterative(int n)
        {
            var arr = new int[] { 0, 1 }; // Initial values in the fibonacchi iteration 
            //begin from 2 
            for (int i = 2; i < n + 1; i++)
            {
                //push in the array the numbers 
                /*
                 * arr.push(arr[i-2] + arr[i-1]); //the elements from the past in the array
                 */
            }
            return arr[n];
            /*
             * Time Speed Complexity
             *  Linear: O(n)
             */
        }

        public static int FibonacciIterativeRecursive(int n) //3
        {
            if (n < 2)
            {
                // if n is 1 or less then return 1 or 0
                return n;
            }
            //The answer is always the 1 and 2 before the sequence 
            return FibonacciIterativeRecursive(n - 1) + FibonacciIterativeRecursive(n - 2);
            /*
             * Time Complexity:
             *  Exponential Time : as there are 2 different trees
             *  O(2^n) - Recursive algorithms that solves problems of normal algorithms of size O(n) 
             */
        }
    }
}
