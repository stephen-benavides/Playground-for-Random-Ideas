using System;

namespace Advanced
{
    class SelectionSortAlgorithm
    {
        //int[] numbers = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
        public int[] SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int min = i; // The first element will always be the minimum 
                int temp = numbers[i]; // number to be replaced is the first one in the array, reference to the original value
                for (int j = i; j < numbers.Length; j++) // -- i+1 is better for the performance as it does not check itself 
                    //If the pointer begins frm 0 aain, then the min value will remain the same. Thus =i instead of 0
                {
                    if (numbers[j] < numbers[min]) // less than numbers[i]
                    {
                        min = j;  // the min is now J (pointer)
                    }
                }
                // At the end of the run the values are assigned
                numbers[i] = numbers[min]; //the first element in the array is the min number in the array (j)
                numbers[min] = temp; //the min element is swapped with the original number[i] temp 
            }

            return numbers;
        }
    }


    class ProgramCaller
    {
        public static void MainCaller(string[] args)
        {
            int[] numbers = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };

            SelectionSortAlgorithm sorting = new SelectionSortAlgorithm();
            int[] nums = sorting.SelectionSort(numbers);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

        }
    }
}