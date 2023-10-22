using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Udemy.Intermediate
{
    public class PropertiesPractice
    {
        //field 
        private DateTime _birthdate;

        //User define, needs field - Use it for advance elements that requiere logic 
        public DateTime BirhDate
        {
            get
            {
                // You can write anything you like and return the type of property 
                // as any other method 
                // Write any logic you want 
                return _birthdate; // Need to return a defined field 
            }
            set { _birthdate = value; }
        }


        //Auto implemented property, no need for field - Use it for simple things 
            /*
             * You can include private modifiers in set or get as any other methods 
             */
        public DateTime Birthdate { get; private set; } 


        /*
         *Order in a class
         *
         * - auto generated properties
         * - Constructors
         * - User generated Properties 
         */
    }
}
