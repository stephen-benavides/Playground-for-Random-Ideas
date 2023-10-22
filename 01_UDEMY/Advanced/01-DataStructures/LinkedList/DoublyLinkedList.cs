using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.LinkedList
{
    class MethodCaller
    {
        public void MainCaller(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList(10);
            list.Append(4);
            //list.PrePend(1);
            list.Append(99);
            list.Insert(1, 255);
            list.Insert(55, 255);
            //list.Insert(2, 55);
            list.DeleteObject(1);
            list.PrintObjects();

            Console.WriteLine("Current Index Value: {0}",list.PrintCurrentNode(2)._prev._value);
            // Console.WriteLine("Hello");

        }
    }
    class NewNode : DoublyLinkedList
    {
        private readonly int _value;

        public NewNode(int value) : base(value)
        {
            _value = value;
            //_value = value;
            _next = null;
            _prev = null; 
        }
    }

    class DoublyLinkedList
    {
        public int _value;
        public int CurrLength = 0; 
        public DoublyLinkedList _next;
        public DoublyLinkedList _prev; //previous

        public DoublyLinkedList _head;
        public DoublyLinkedList _tail;
        


        public DoublyLinkedList(int value)
        {
            this._value = value;
            this._head = new DoublyLinkedList(value, null, null);
            this._tail = this._head;
            //this._prev = this._head;
        }

        public DoublyLinkedList(int value, DoublyLinkedList next, DoublyLinkedList _bottom)
        {
            this._value = value;
            this._next = null;
            this._prev = null;
        }

        public void Append(int value)
        {
            NewNode newNode = new NewNode(value);
            var prevNode = this._tail;
            newNode._prev = prevNode;
            prevNode._next = newNode;
            this._tail = prevNode._next;
            CurrLength++;
        }

        public void PrePend(int value)
        {
            NewNode newNode = new NewNode(value);
            newNode._next = this._head;
            this._head._prev = newNode;
            this._head = newNode;
            CurrLength++;
        }

        public void Insert(int index, int value)
        {
            if(index == 0)
                this.PrePend(value);
            if(index >= CurrLength)
                this.Append(value);
            else
            {
                var prevNode = this._head;

                for (int i = 0; i < index - 1; i++)
                {
                    prevNode = prevNode._next;
                }

                var aftNode = prevNode._next;
                var newNode = new NewNode(value);

                prevNode._next = newNode;
                newNode._next = aftNode;
                newNode._prev = prevNode;
                //missing
                aftNode._prev = newNode;
                CurrLength++;
            }
        }

        public void DeleteObject(int index)
        {
            var prevNode = this._head;
            for (int i = 0; i < index - 1; i++)
            {
                prevNode = prevNode._next; 
            }

            var aftNode = prevNode._next._next;
            prevNode._next = aftNode;
            aftNode._prev = prevNode; 
        }

        public void PrintObjects()
        {
            List<int> ints = new List<int>();

            var currentNode = _head;

            while (currentNode != null)
            {
                ints.Add(currentNode._value);
                currentNode = currentNode._next; 
            }

            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }

        }

        public DoublyLinkedList PrintCurrentNode (int index)
        {
            var currNode = this._head;
            for (int i = 0; i < index; i++)
                currNode = currNode._next;
            return currNode;
        }

    }
}
