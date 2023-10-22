using System;
using System.Collections.Generic;


namespace Advanced._01_DataStructures.StacksQuees
{
    class StackLinkedList<T>
    {
        public ListNode<T> top;
        public ListNode<T> bottom;
        public int length;
        public  T value; 

        public StackLinkedList(T value)
        {
            this.value = value;
            this.bottom = new ListNode<T>(value);
            this.top = bottom;
            this.length = 0;
        }

        public void Push(T value)
        {
            var newNode = new ListNode<T>(value, null);
            var holdingPointer = this.top; //original pointer to the top
            this.top = newNode;
            this.top.next = holdingPointer;
            this.length++;
            //this.print();
        }

        public T Peek()
        {
            if (this.top == null)
                return default(T);
           
            return this.top.value;
        }

        public void Pop()
        {
            if (this.length == 0)
            {
                this.top = null;
                this.bottom = null;
            }
            else
            {
                // var prevNode = this.bottom;
                // int index = 0;
                // while (index < this.length - 1)
                // {
                //     prevNode = prevNode.next;
                //     index++;
                // }
                // //var currNode = prevNode.next;
                // prevNode.next = null;
                // this.top = prevNode;
                // this.length--;
                // //this.print();


                //var holdingPointer = this.top; --> Not needed,
                //this is a current reference of the object that
                //is about to be eliminated, it will get garbage collected if it is not used 
                this.top = this.top.next;
                this.length--;
            }
        }

        public bool isEmpty()
        {
            return this.bottom == null;
        }

        public void Reverse()
        {
            var firstNode = this.bottom;
            var secondNode = firstNode.next;
            this.top = this.bottom;
            while (secondNode != null)
            {
                var temp = secondNode.next;
                secondNode.next = firstNode; 
                firstNode = secondNode;
                secondNode = temp; 
            }

            top.next = null;
            this.bottom = firstNode;
            this.print();
        }

        public void print()
        {
            var list = new List<T>();

            var currNode = this.top;
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

    class ListNode <T>
    {
        public T value;
        public ListNode <T> next;


        public ListNode(T value)
        {
            //this.head = new ListNode(value, null);
            //this.tail = this.head;
            this.value = value;
            //this.length = 0; 
        }

        public ListNode(T value, ListNode<T> next)
        {
            this.value = value;
            this.next = next; 
        }


    }
}
