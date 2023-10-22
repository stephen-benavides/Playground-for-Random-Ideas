using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.RandomExercises
{
    class IterateOverInterfaceElements
    {
        public class Program
        {
            public static void MainProgram(string[] args)
            {
                ShapeIterator shape = new ShapeIterator();
                shape.IterateShapes(new List<Shapes>(2) {new Circle(), new Square()});
            }
        }

        public interface Shapes
        {
            void Draw();
        }

        public class Circle : Shapes
        {
            public void Draw()
            {
                Console.WriteLine("Draw Circle");
            }
        }

        public class Square : Shapes
        {
            public void Draw()
            {
                Console.WriteLine("Draw Square");
            }
        }

        public class ShapeIterator
        {
            //private readonly Shapes _shapes;

            public ShapeIterator()
            {
            }

            public void IterateShapes(List<Shapes> shapes)
            {
                foreach (var shape in shapes)
                {
                    shape.Draw();
                }
            }
        }
    }
}