using System;

namespace Cognizant
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 2; i++)
            {
                sum += 3*i;
            }

            Console.WriteLine(sum);
        }
    }
}
