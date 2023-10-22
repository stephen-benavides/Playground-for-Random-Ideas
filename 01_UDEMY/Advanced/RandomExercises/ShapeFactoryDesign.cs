using System;
using System.Collections.Generic;

namespace Advanced.RandomExercises
{
    internal class ShapeFactoryDesign
    {
    }


    public class ProgramCall
    {
        public static void MainCaller(string[] args)
        {
            var processing = new ProcessingShapes(new List<IShape>
            {
                new Circle(),
                new Rectangle()
            });
            processing.DrawShape();
        }
    }

    internal interface IShape
    {
        void draw();
    }

    internal class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Circle");
        }
    }

    internal class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle");
        }
    }

    internal class ProcessingShapes
    {
        private readonly List<IShape> _shape;


        public ProcessingShapes(List<IShape> shape)
        {
            _shape = shape;
        }

        public void DrawShape()
        {
            foreach (var shape in _shape) shape.draw();
        }
    }
}