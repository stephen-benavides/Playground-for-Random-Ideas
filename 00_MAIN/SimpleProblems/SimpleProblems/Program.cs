using System;

namespace SimpleProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockInject b = new BlockInject("Albert");
            b.sayHello();
            InjectionOne io = new InjectionOne(b);
            Console.WriteLine(io.getName());
            
        }
    }
}
