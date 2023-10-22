using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced.LinkedList;

namespace Advanced.Is_As_Differences
{
    class IsAsDifference
    {
        private Object a = null;

        public void IsAs()
        {
            Object b = null;
            LinkedListSelf list = new LinkedListSelf(10);
            if(b is LinkedListSelf)
                Console.WriteLine("True"); // It will not be true, it looks for an "Is - a" relationship. Object is not a list, a list is a object 

            var conversion = b as LinkedListSelf;
            var listObjects = conversion.head; // this will be "valid" as we can unbox the object as an object that inehrits from it thus giving us access to their members 


            /*
             *
             * Boxing vs Unboxing
             *
             * Boxing: put an int value into an object variable
             * Unboxing: Downcasting object value to an int 
             */
        }
    }
}
