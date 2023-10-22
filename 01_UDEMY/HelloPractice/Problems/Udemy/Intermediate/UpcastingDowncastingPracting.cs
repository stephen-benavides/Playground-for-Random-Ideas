using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Udemy.Intermediate
{
    class UpcastingDowncastingPracting
    {
        public void callMethod()
        {
            Circle circle = new Circle();
            Shape shape = new Circle(); // has-a relationship 
            Shape anotherShape = circle; //same as line 15 
            shape.size();

            Circle anotherCircle = (Circle)shape; //is-a relationship
            anotherCircle.size();


            Cars cars = new Cars();

            // Make sure result is not null using as 
            Shape shape2 = circle as Shape; // as will return null if it is not 
            if (shape2 != null)
            {
                Console.WriteLine("Shape2 is not null");
            }

            // Check if an object is of a certain type to proceed operation 
            if (circle is Shape) // affirming that circle is a Shape to then do something 
            {
                Shape shape3 = circle; 
            }
        }
    }

    class Shape
    {
        public void size()
        {
            Console.WriteLine("Standard Size");
        }
    }

    class Circle : Shape
    {
        public void size()
        {
            base.size();
            Console.WriteLine("Medium Size");
        }
    }

    class Cars
    {
        public void size()
        {
            Console.WriteLine("Big Size");
        }
    }

}



/*class Program

{
    static void Main(string[] args)
    {
        var upcastingDowncasting = new UpcastingDowncastingPracting();
        upcastingDowncasting.callMethod();
    }
}*/