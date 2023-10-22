using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Udemy.Intermediate
{
    class BasePractice
    {
        public void callMehod()
        {
            var car = new Car("0123");
        }

    }

    class Vehicle
    {
        private readonly string _regitrationNumber;

        // public Vehicle()
        // {
        //     Console.WriteLine("Vehicle is being initialized");
        // }

        public Vehicle(string regitrationNumber)
        {
            _regitrationNumber = regitrationNumber;
            Console.WriteLine("Vehicle is being initialized, {0}", regitrationNumber);
        }
    }

    class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }


    }

    /*
     *  class Program
    
    {
        static void Main(string[] args)
        {
            BasePractice basePractice = new BasePractice();
            basePractice.callMehod();

        }
    }
     *
     */
}
