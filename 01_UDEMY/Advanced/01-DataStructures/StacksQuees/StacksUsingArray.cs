using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._01_DataStructures.StacksQuees
{
    class StacksUsingArray
    {
        public void MainCaller()
        {
            ArrayPractice practice = new ArrayPractice();

            //practice.Push(8);
            //practice.Push(10);
            //practice.Push(40);
            int[] a = new int[5];
            a[0] = 20;
            Console.WriteLine(a[1]);
        }
    }

    public class ArrayPractice
    {
        private int length;
        private int[] arrayInts;
        private int index;

        public ArrayPractice()
        {
            this.length = byte.MaxValue;
            this.arrayInts = new int[this.length];
            this.index = 0;
        }

        public void Push(int element)
        {
            arrayInts[index] = element;
            this.print();
            index++;
        }

        private void print()
        {
            Console.WriteLine("INDEX: {0} + VALUE: {1}", index, arrayInts[this.index]);

        }
    }
}
