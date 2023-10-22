using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.AlgorithmicalExercises
{
    class TwoSumSolution
    {
        //O(n) Solution Using Arrays, Space Complexity O(n)

        public int[] TwoSum(int[] input, int target)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int sum = target - input[i];

                if (input[i] == sum && Array.IndexOf(input, sum) != i)
                {
                    return new int[] {Array.IndexOf(input, sum), i};
                }
            }

            throw new ArgumentException();
        }

        public int[] TwoSumMap(int[] input, int target)
        {
            IDictionary<int, int> solution = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                
                solution.Add(input[i], i);
                int sum = target - input[i];

                if (solution.ContainsKey(sum) && solution[sum] != i)
                {
                    return new int[] {sum, input[i]};
                }
            }
            

            throw new ArgumentNullException();
        }


        public static void MainCaller()
        {
            // SUm of 2 numbers 
            int[] input = new int[] {1, 2, 4, 5};
            TwoSumSolution twoSum = new TwoSumSolution();
            foreach (var i in twoSum.TwoSum(input, 8))
            {
                Console.WriteLine(i);
            }
        }
    }
}