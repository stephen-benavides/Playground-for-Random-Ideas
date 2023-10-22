using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._02_Algorithms.Searching
{
    class BinarySearchAlgorithm
    {
        public int BinarySearch(int[] numbers, int l, int r, int target)
        {
            if (r >= l)
            {
                int middle = l + (r - l) / 2;
                if (numbers[middle] == target)
                {
                    return target;
                }

                if (target > numbers[middle])
                {
                    return BinarySearch(numbers, middle + 1, r, target);
                }
                return BinarySearch(numbers, l, middle - 1, target);
            }

            return -1;
        }
        // Only works for sorted elements 
    }
}
