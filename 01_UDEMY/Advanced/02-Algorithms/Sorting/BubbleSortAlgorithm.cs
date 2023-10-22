using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._02_Algorithms.Sorting
{
    public class ProgramCaller
    {
        public static void MainCaller(string[] args)
        {
            BubbleSortAlgorithm sort = new BubbleSortAlgorithm();
            int[] numbers = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            // Move elements from left to right if they are bigger until there are no more such elements 

            BubbleSortAlgorithm test = new BubbleSortAlgorithm();

            foreach (var i in test.bubbleSort(numbers))
            {
                Console.WriteLine(i + " ");
            }

        }
    }

    class BubbleSortAlgorithm
    {
        public int[] bubbleSort(int[] array)
        {
            //int[] numbers = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            int length = array.Length;
            // For every iteration, run the entire array 
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;  //array[j];
                    }
                }

            }

            return array;
        }
    }
}
