using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Udemy.Intermediate
{
    public class MethodPractice
    {
        //Overloading multiple values in numbers 
        public int Add(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public void PrintReference(int[] numbers)
        {
            Console.WriteLine(Add(numbers));
        }

        // You can avoid defining multiple arrays by using the params keyword 
        /// <summary>
        /// Uses arrays of varying size, no need to define others 
        /// </summary>
        /// <param name="numbers">any number without defining array first, linear approach</param>
        /// <returns>sum of the numbers passed in the method</returns>
        public int AddParams(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
            return sum;
        }
    }

    // Set of Number to use in the above application for practice 
    class NumberSet
    {
        /// <summary>
        /// Returns back the array that was selected in the parameter
        /// </summary>
        /// <param name="select">Selection of Data</param>
        /// <returns>an array of numbers</returns>
        public static int[] NumberArray(String select)
        {
            int[] a = new[] { 1, 2, 3, 4, 5, 6 };
            int[] b = new int[] { 1, 2, 3, 4 };
            int[] c = new int[4];

            switch (select)
            {
                case "a":

                    return a;
                    break;
                
                case "b":
                    return b;
                    break;
                case "c":
                    return c;
                    break;

                default:
                {
                    Console.WriteLine("Not on the system");
                    return c;
                    break;
                }
            }
        }
    }

    class ProgramPlaceHolder
    {
        static void MainPlaceHolder(string[] args)
        {
            MethodPractice methodPractice = new MethodPractice();
            methodPractice.PrintReference(NumberSet.NumberArray("d"));
            //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Params Numbers");
            methodPractice.AddParams(1, 2, 3, 4);

            //////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Ref Modifier");
            /*var number = int.Parse("abc");
            Console.WriteLine(number); 

            Return Exception 
            */

            int number; // Must define number on the ouside to store the value into 
            var result = int.TryParse("123", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion Failed");
            }

        }
    }

}
