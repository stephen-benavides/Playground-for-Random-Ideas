using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.AlgorithmicalExercises
{
    class FirstRecurringCharacter
    {
        /*
         *Find the first recurring character in the array
         *
         * array = [2,5,1,2,3,5,1,2,4];
         *      return 2;
         *
         * array = [2,1,1,2,3,5,1,2,4];
         *      return 1
         *
         * array = [2,3,4,5];
         *      return undefined 
         *
         */

        public static int? Solution(int[] arr)
        {
            int p1 = 0;
            int? number = null;

            HashSet<int> set = new HashSet<int>();

            while (p1 < arr.Length)
            {
                if (set.Contains(arr[p1]))
                {
                    number = arr[p1];
                    return number;
                }
                else
                {
                    set.Add(arr[p1]);
                    p1++;
                }
            }

            throw new ArgumentNullException("Nothing");
        }

        public static int? Solution2(int[] arr)
        {
            Hashtable table = new Hashtable() { }; // Space complexity of O(n) // based on the for loop, not the input

            object a, b;
            for (int i = 0; i < arr.Length; i++)
            {
                if (table.ContainsKey(arr[i]))
                {
                    return arr[i];
                }
                else
                {
                    table[arr[i]] = i; // Key is the value of the array, the value is the index 
                }


                foreach (DictionaryEntry dictionaryEntry in table)
                {
                    dictionaryEntry.Deconstruct(out a, out b);
                    Console.WriteLine((int)a + "\t" + (int)b);
                }
            }

            throw new ArgumentNullException("Nothing");
        }
    }

    class MethodCaller
    {
        public static void MainProgram(string[] args)
        {
            int[] arr = new int[] { 2, 5, 5, 2, 3, 5, 1, 2, 4 };
            try
            {
                Console.WriteLine(FirstRecurringCharacter.Solution2(arr));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
}
}
