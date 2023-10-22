using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.AlgorithmicalExercises
{
    class ReverseString
    {
        void ReverseSomething()
        {
            String a = "ierdnA si eman iH";
            //string[] b = a.Split();



            int p1 = 0;
            int p2 = a.Length - 1;

            char[] sol = new char[a.Length];

            while (p2 >= 0)
            {
                sol[p1] = a[p2];
                p1++;
                p2--;
            }

            foreach (var s in sol)
            {
                Console.Write(s);
            }

        }
    }
}
