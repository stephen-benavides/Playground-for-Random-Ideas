using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.RandomExercises
{
    class UsingThis
    {
        public UsingThis getThis()
        {
            return this;
        }

        public static void MainCaller(string[] args)
        {
            UsingThis ts = new UsingThis();
            Console.WriteLine(ts.getThis() == ts);

            // "this" refers to what object you are inside of

            /*
             * "This" is the context
             *      It is similar to the current scrope of the object
             *
             * 'this' workins within functions too, this will bring the current scope of the object (function/class) you are in
             *      Function does not existing in OOP 
             */


            //CtorTest2 test2 = new CtorTest2("Jhon", 32);
            //Console.WriteLine(test2._name);


        }
    }
}
