using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace PoblemResolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToString().Trim()
            //AlgorithmicalExercises.ArraySumOutput(new int[]{3, 5, 1, 8, -7, 3, 2, 1, 7, 2, 4, 5, 8, 2, 10, 2, 3, 4, 1}, 10);
        }
    }

    class AlgorithmicalExercises
    {
        //
        public static void ArraySumOutput(int[] array, int input)
        {
            int p = 0;
            List<List<int>> list = new List<List<int>>(); 
            
            while (p < array.Length)
            {
                int innerP = p;
                int sum = 0;
                List<int> index = new List<int>();
                 while (innerP < array.Length)
                 {
                     if (sum < input)
                    {
                        sum += array[innerP];
                        index.Add(innerP);
                        innerP++;
                    }

                    else if (sum == input)
                    {
                        List<int> nums = new List<int>();
                        foreach (var i in index)
                        {
                            nums.Add(array[i]);
                        }
                        list.Add(nums);
                        index.Clear();
                        sum = 0;
                        break;
                    }
                    else
                    {
                        index.Clear();
                        sum = 0;
                        p++;
                        innerP = p;
                    }
                }
                p++;
            }

            foreach (var arr in list)
            {
                Console.WriteLine("New Array");
                foreach (var i in arr)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void ReadCharacter(String input)
        {
            input = input.ToUpper();
            input = Regex.Replace(input, @"\s+", "");
            int p = 0;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            while (p < input.Length)
            {
                //if the character is not in the dictionaty
                if (!dictionary.ContainsKey(input[p]))
                {
                    dictionary.Add(input[p], 1);
                }
                else
                {
                    int output;
                    if (dictionary.TryGetValue(input[p], out output))
                        dictionary[input[p]] = ++output;
                }

                p++;
            }

            foreach (var i in dictionary)
            {
                Console.WriteLine(i);
               // Console.WriteLine(i.Key + '\t' + i.Value);
            }
        }
    }
}
