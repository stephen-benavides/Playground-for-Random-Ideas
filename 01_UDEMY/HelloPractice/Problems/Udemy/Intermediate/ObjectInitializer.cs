using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Udemy.Intermediate
{
    class ObjectInitializer
    {
        private Person person = new Person
        {
            FirstName = "Mosh"
        };
    }

    public class Person
    {
        public String FirstName;
        public String LastName;
        public Person()
        {
            Console.WriteLine("Person Ctor");
        }

        public  void CallPersonMethods()
        {
            CallFirstName();
        }

        public void CallFirstName()
        {
            Console.WriteLine(this.FirstName);
        }
    }
}
