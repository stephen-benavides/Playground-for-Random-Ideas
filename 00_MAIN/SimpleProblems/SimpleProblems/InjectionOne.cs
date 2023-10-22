using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProblems
{
    public class InjectionOne
    {
        public BlockInject block; 
        public InjectionOne(BlockInject block)
        {
            this.block = block;
        }

        public String getName()
        {
            return block.name;
        }
    }
}
