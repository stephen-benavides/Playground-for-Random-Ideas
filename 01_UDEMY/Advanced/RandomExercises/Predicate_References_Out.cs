using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.RandomExercises
{
    class Predicate_References_Out
    {
        public static bool isTrue(int i, out int a)
        {
            a = (i < 4) ? 6 : 10;
            return true;
        }

        public static void MainCaller(string[] args)
        {
            int output = 0;
            Predicate<int> myPred = (i => isTrue(i, out output));


            Console.WriteLine(output); //output is 0 as it hasn't run yet
            Console.WriteLine(myPred(5));
            Console.WriteLine(output); //output is 10 because the predicate ran 

        }
    }
}
