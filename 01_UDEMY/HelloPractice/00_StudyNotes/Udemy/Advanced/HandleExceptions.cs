/*using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using HelloPractice.Problems.Random;
using HelloPractice.Problems.Udemy;
using HelloPractice.Problems.Udemy.Intermediate;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace HelloPractice
{
    class Program

    {
        static void Main(string[] args)
        {
            try
            {
                var test1 = new ObjectInitializerTest
                {
                    lname = "edo",
                    name = "effing"
                };

                Console.WriteLine(test1.name);
                Console.WriteLine(test1.lname);
            }
            catch (Exception e)
            {
                if (e is CustomExceptions exception)
                {
                    exception.message();
                }
                //throw;
            }





        }

    }
    //Write any class outside of program and use ALT+ENTER to move it to another .cs file 

    class ObjectInitializerTest
    {
        private string _lname;
        public string name { get; set; }

        public int number { get; set; }


        public string lname
        {
            get { return _lname; }
            set
            {
                if (value == "edo")
                    throw new CustomExceptions();

                else
                    this._lname = value;

            }
        }
    }

    class CustomExceptions : Exception
    {
        public void message()
        {
            Console.WriteLine("No edo is allowed, bitch");
        }
    }

}*/