using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using HelloPractice.Problems.Random;
using HelloPractice.Problems.Udemy;
using HelloPractice.Problems.Udemy.Intermediate;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace HelloPractice
{
    class Program

    {
        public static void Main(string[] args)
        {
            int num1, num2;

           var a = new Func<int, int, int>((num1, num2) => num1 * num2);

           Console.WriteLine(a(5,8));
        }

        public static int multi(int num)
        {
            return num * num;
        }

    }

    /*
     *
     * Create tasks to process an immage
     * the tasks include resizing, change brightness and change format 
     */



}