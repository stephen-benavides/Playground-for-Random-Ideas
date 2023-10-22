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
            var numbers = new GenericsPractice<int>(); // need to define the object that is being passed in the instantiation 
            numbers.Add(10);

            var book = new GenericsPractice<string>(); // passing string 
            book.Add("One Book");

            Console.WriteLine(numbers[0]);
            Console.WriteLine(book[0]);

            var list = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("List Object 1: {0}, 2: {1}", list[0], list[1]);


        }



    }
    //Write any class outside of program and use ALT+ENTER to move it to another .cs file 

    class GenericsPractice<T> //Need to pass the T for generics at the class level 
    {
        private readonly List<T> _elementList; //pass any T type 

        public GenericsPractice()
        {
            _elementList = new List<T>();
        }
        public GenericsPractice(List<T> elementList)
        {
            _elementList = elementList;
        }

        public void Add(T value)
        {
            _elementList.Add(value);
        }

        public T this[int index] //Return anything that is stored in the given index 
        {
            get => _elementList[index];
        }
    }
}*/