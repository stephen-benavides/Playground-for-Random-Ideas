using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Udemy.Beginners
{
    public class EnumsPractice
    {
        // Make reference what type of primitive you are using, ex: 
            // byte, short, int, long, float, double
        public enum EmailList //: int
        {
            Jhon= 64, 
            Albert= 32,
            Nick = 8,
            Richard = 10

        }

        /*
         * Main 
         *  var eCall = EnumsPractice.EmailList.Jhon;
         *  
         *  -- Downcast to get val stored in enum 
         *  Console.WriteLine((byte)eCall);
         *  
         *  -- Upcast to get enum reference from val 
         *  Console.WriteLine((EnumsPractice.EmailList)8);
         *  
         *  -- Convert String into enum 
         *   var methodName = "Richard";
         *      -- Converts the enum from object to Email List 
            var  shippingMethod = (EnumsPractice.EmailList)Enum.Parse(typeof(EnumsPractice.EmailList), methodName);
         *
         *  -- Pass Enums at run time 
         *  var enumName = "Richard";
            var shippingMethod = (EnumsPractice.EmailList)Enum.Parse(typeof(EnumsPractice.EmailList), enumName);
            Console.WriteLine((int)shippingMethod);



         *  
         *  -- THIS DOES NOT WORK 
         *  EnumsPractice enumsPractice = new EnumsPractice();
         *  
         */
    }
}
