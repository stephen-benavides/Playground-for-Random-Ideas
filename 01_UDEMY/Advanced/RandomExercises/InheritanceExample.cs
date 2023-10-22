using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.RandomExercises
{
    class InheritanceExample
    {

    }


    public class ProgramCaller
    {
        public static void MainCaller(string[] args)
        {
            Cat p = new Cat();
            p.callCat();
        }

    }

    class Animal
    {
        public void walk()
        {
            Console.WriteLine("The Animal Walks");
        }
    }

    class Cat : Animal
    {
        public string name = "Pepper";

        public void callCat()
        {
            walk();
        }
    }

}
