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



        }



    }
    //Write any class outside of program and use ALT+ENTER to move it to another .cs file 

    class Product
    {
        public string name { get; set; }
        public int size { get; set; }
    }

    // Class Level 
    class DiscountCalc1<T> where T : Product // Think of this as defining a new variable
    {
        private int CallCalculator(T getProduct)
        {

            return getProduct.size;
        }
    }


    //Interface level 
    class DiscountCalculator //<TCompare> where TCompare : IComparable
    {
        // public int CompareValues(int a, int b)
        // {
        //     return  (a > b) ? a : b;
        // }

        public TCompare CompareValues<TCompare>(TCompare a, TCompare b) where TCompare : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}*/