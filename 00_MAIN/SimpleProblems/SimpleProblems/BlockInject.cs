using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProblems
{
    public class BlockInject
    {
        public String name { set; get; }
        public BlockInject(String name)
        {
            this.name = name; 
        }

        public BlockInject()
        {

        }

        

        public void sayHello()
        {
            Console.WriteLine("Hello World " + this.name);
        }

  
    }
}
