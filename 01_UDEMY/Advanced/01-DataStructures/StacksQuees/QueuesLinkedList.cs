using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._01_DataStructures.StacksQuees
{
    class QueuesLinkedList
    {
        public void MainCaller()
        {
            Queue queue = new Queue();
            queue.Enqueue(40);
            queue.Enqueue(10);
            //queue.Dequeue();
            //queue.Dequeue();
            queue.Print();

            Console.WriteLine("Length:{0}", queue.length);
            queue.Reverse();
        }
    }

    class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
        }

        public Node(int value, Node next)
        {
            this.value = value;
            this.next = next;
        }
    }

    class Queue
    {
        private Node head;
        private Node tail;
        public int length;

        public Queue()
        {
            this.length = 0;
        }

        //add at the end of the list 
        public void Enqueue(int value)
        {
            //When inserting the firtst element, if the length is 0 then initialize the head 
            if (this.length == 0)
            {
                this.head = new Node(value, null);
                this.tail = this.head;
            }
            else
            {
                var newNode = new Node(value, null);
                this.tail.next = newNode;
                this.tail = newNode;
            }

            this.length++;
        }

        public void Dequeue()
        {
            if (this.length == 0)
                throw new ArgumentNullException("No more elements in the array"); //return null 

            if (this.head == this.tail)
                this.head = null;

            this.head = this.head.next;
            this.length--;
        }

        /// <summary>
        /// stack the elements on top of one another (LIFO) 
        /// </summary>
        /// <param name="value"></param>
        public void Stack(int value)
        {
            //When inserting the firtst element, if the length is 0 then initialize the head 
            if (this.length == 0)
            {
                this.head = new Node(value, null);
                this.tail = this.head;
            }
            else
            {
                var newNode = new Node(value);
                var tempTopNode = this.head;
                this.head = newNode;
                this.head.next = tempTopNode;
            }

            this.length++;
        }

        public void Reverse()
        {
            var firstNode = this.head;
            var secondNode = firstNode.next;
            this.tail = firstNode;
            while (secondNode != null)
            {
                var tempNode = secondNode.next;
                secondNode.next = firstNode;
                firstNode = secondNode;
                secondNode = tempNode;
            }

            this.tail.next = null;
            this.head = firstNode;
            this.Print();
        }
        public void Print()
        {
            List<int> list = new List<int>();
            var currNode = this.head;
            while (currNode != null)
            {
                list.Add(currNode.value);
                currNode = currNode.next;
            }

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
