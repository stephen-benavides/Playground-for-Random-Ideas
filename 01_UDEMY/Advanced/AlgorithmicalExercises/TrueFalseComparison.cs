using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.AlgorithmicalExercises
{
    class TrueFalseComparison
    {
        /*
         * EXERCISE
         *
         * Given 2 arrays, create a function
         * that lets user know (True or False)
         * where two arrays contain any common items
         *
         * Example 1
         * const array1 = ['a', 'b', 'c', 'x'];
         * const array2 = ['z', 'y', 'i'];
         * should return false 
         *
         *
         * Example 2 
         * const array1 = ['a', 'b', 'c', 'x'];
         * const array2 = ['z', 'y', 'x'];
         * should return true
         */
        public Boolean SolutionBruteApproach(char[] input1, char[] input2)
        {
            for (int i = 0; i < input1.Length; i++)
            {
                for (int j = 0; j < input2.Length; j++)
                {
                    if (input1[i] == input2[j])
                        return true;
                }
            }

            return false;
        }
        // Time Complexity: O(a*b) because the array can be of different sizes
        // Space Complexity : O(1) -constant- because we are not creating any new variables, we are using the input from the user 



        public Boolean SolutionBetterApproach(char[] input1, char[] input2)
        {
            // Use HashTables 

            Dictionary<char, Boolean> myDictionary = new Dictionary<char, bool>();

            //Throw error if the inut is not a character 
            //You can solve this by reading each input and changing into a string and adding it into another array 


            //throw error if data does not exist  -- Always at the begigning because it will run first 
            if (input1 == null || input2 == null || input1.Length == 0 || input2.Length == 0) // Order matters 
                throw new ArgumentNullException("No data");

            //Add data into array with default value of true 
            for (int i = 0; i < input1.Length; i++)
            {
                myDictionary.Add(input1[i], true);
            }

            //Check if array 2 contains the result, if it does return the element in the dictionary 
            for (int i = 0; i < input2.Length; i++)
            {
                if (myDictionary.ContainsKey(input2[i]))
                    return myDictionary[input2[i]]; //myDictionary[a]
            }

            return false;
        }
        // Time Complexity: O(a+b) - There are 2 loops but they are not nested, they are added together 
        // Space Complexity: O(a) - We are adding into a collection based on the loop which takes memory 
    }

    /*
     * Faster solution is not always the best solution,
     * if memory is expensive we need to use the first
     * approach which takes more time but no memory
     *
     */


    /*
     * Always write code is modular ways (small pieces that are easy to read in english)
     *
     * You can break the above steps into methods that take input,
     * so it will be more readable
     * Modular mean that 1 piece of code should be able to do 1 thing really well,
     * a function should never have too many steps
     *
     */







    public class ProgramCaller
    {
        public static void MainCaller(string[] args)
        {


            try
            {

                TrueFalseComparison trueFalse = new TrueFalseComparison();
                char[] input1 = { 'a', 'b', 'c', 'x' };
                char[] input2 = null;//{ 'a', 'c', 'i' };

                Console.WriteLine(trueFalse.SolutionBetterApproach(input1, input2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }

    }

}
