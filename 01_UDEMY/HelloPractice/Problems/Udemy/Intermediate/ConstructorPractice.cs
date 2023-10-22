using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPractice.Problems.Udemy
{
    public class ConstructorPractice
    {
        private string name;

        private string b;

        private string c;
        // Use ctor (constructor) + Tab to create a constructor ASAP
        /*
         * By using :this()
         * You can call the no argument constructor to inherit from, it work the same as super from Java 
         */
        public ConstructorPractice()
        {
            Console.WriteLine("No Argument Constructor");
        }
        public ConstructorPractice(String b, String c) : this()
        {
            var thirdCons = string.Format("String b:{0} = x, String c:{1} = y", b, c);
            Console.WriteLine("2 Argument Constructor");
            Console.WriteLine(thirdCons);
            this.b = b;
            this.c = c;
        }

        public ConstructorPractice(String a) : this(a,a)
        // Pass String a as arguments from the previous constructor as (String b & String c) 
        {
            Console.WriteLine("1 Argument Constructor");
            this.name = a;
        }

        public ConstructorPractice(String x, String y, String z):this(b:x, c:y)
        {
            Console.WriteLine("3 Argument Ctor");
            this.name = x;
            this.b = y;
            this.c = z;
            Console.WriteLine(this.c);
        }

        public  void CallCtor()
        {
            Console.WriteLine(name);
        }
    }
}
