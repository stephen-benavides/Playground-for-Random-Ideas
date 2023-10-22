using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.LinkedList
{
    // Single Linked List 
    class Program
    {
        public static void MainCaller(string[] args)
        {
            LinkedListSelf list = new LinkedListSelf(10);
            list.Append(5);
            list.Append(8);
            // list.Prepend(2);

            // 
            list.Insert(1, 77);
            list.Insert(2, 99);

            // list.Remove(3);
            Console.Write("Normal List: ");
            list.PrintList();
            Console.WriteLine();
            Console.WriteLine("Reversed List ");
            list.Reverse2();
        }
    }


    // Represents a new node for the below code to avoid duplicate code 
    class Node
    {
        private readonly int _value;
        private readonly LinkedListSelf _next;

        public Node(int value)
        {
            _value = value;
            _next = null;
        }

    }

    //Linked List Class 
    class LinkedListSelf
    {
        public int value;
        public LinkedListSelf next;


        public LinkedListSelf tail; //tail
        public LinkedListSelf head;


        public int length = 1;


        // pasing values o the linked list
        public LinkedListSelf(int value)
        {
            this.value = value;
            head = new LinkedListSelf(value, null);
            tail = head;

        }

        public LinkedListSelf(int value, LinkedListSelf next)
        {
            this.value = value;
            this.next = next;
        }


        /// <summary>
        /// Append new value at the end of the linked list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public LinkedListSelf Append(int value)
        {
            // the new node will have a null at the end, no data  ---- Can be replaced by "Node" class
            LinkedListSelf newNode = new LinkedListSelf(value, null);
            this.tail.next = newNode; // next node is the new node 
            this.tail = this.tail.next; // tail is the new next node 
            this.length++;
            return this;
        }

        /// <summary>
        /// Puts a value at the top of the list
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public LinkedListSelf Prepend(int value)
        {
            this.value = value;
            LinkedListSelf newNode = new LinkedListSelf(this.value, null);
            //var tempNode = head.next;
            newNode.next = this.head; // Creating a pointer from the new node 
            this.head = newNode;
            this.length++;
            return this;
        }


        /// <summary>
        /// Insert value into linkedlist based on the index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void Insert(int index, int value)
        {
            if (index == 0)
                this.Prepend(value);
            else
            {
                var preNode = this.head;
                for (int k = 0; k < index - 1; k++) // get the previous node 
                {
                    /*
                     * At index 0, preNode is already the next value
                     * Thats why we use < instead of <= otherwise we wouldnt get the right result
                     * we use index - 1 to get 2 values less that the inserted index to get the index of the value at 1 (if index = 3)
                     *
                     * x < index -1
                     * x < 3 - 1
                     * x < 2
                     * x can only be 1 
                     */
                    preNode = preNode.next; // previous node
                }

                LinkedListSelf newNode = new LinkedListSelf(value, null); // new node
                var aftNode = preNode.next; // after node 

                preNode.next = newNode;
                newNode.next = aftNode; // The order of the 2 make no difference 
            }

            this.length++;
        }


        /// <summary>
        /// Remove the elements based on the index
        /// </summary>
        /// <param name="index">index of the element to remove</param>
        public void Remove(int index)
        {
            var prvNode = this.head;
            int counter = 0;
            /*while (counter != index - 1)
            {
                prvNode = prvNode.next;
                counter++;
            }*/

            // IT reads from 0 index in the array 

            for (int i = 0; i < index - 1; i++)
            {
                prvNode = prvNode.next;
            }

            var currentNode = prvNode.next;
            prvNode.next = currentNode.next;

        }

        public void Reverse2()
        {
            var first = this.head;
            var second = first.next;
            this.tail = this.head;

            while (second != null)
            {
                var temp = second.next;
                second.next = first; 
                first = second;
                second = temp; 
            }

            this.head = first;
            this.tail.next = null;
            this.PrintList();
        }

        /// <summary>
        /// Reverses current Singled Linked List 
        /// </summary>
        public void Reverse()
        {
            /*if (this.head.next == null)
            {
                return this.head;
            }*/

            var first = this.head; //current node 
            // --before the loop, the tail becomes the head
            this.tail = this.head; 
            var second = first.next; //next node 
            while (second != null) // While there is a second value 
            {
                var temp = second.next; // THESE ARE POINTERS. I am not making changes to the values 
                second.next = first; //second.next is now pointing to the value f the first node
                first = second;
                second = temp;
                /*
                 * The temp is pointing to the 3rd value
                 * the second.next pointer is pointing to the first value now (.next makes referenece to the other pointer <-) 
                 * the first pointer has been shifted to the second value
                 * the second value has been shifted to the 3rd value
                 *
                 * These continues until the second node is null
                 */
            }

            this.head.next = null; //up to this point the head is still the previous head (10) 
            this.head = first; // now the head is the first value after the while loop (8) 

            /*
             * Passing value by reference vs by value
             *  The referenced element can change the original because it is pointing to a space of memory, they are the same
             * second.next = first is making sure the second value is the previous first so it will add up from first to first second
             *  we already defined second as first.next so second.next will be the continuation to overwrite (first.next) 
             */



            this.PrintList(); // print the list of current values 
        }


        /// <summary>
        /// Print all the values in the list 
        /// </summary>
        public void PrintList()
        {
            List<int> nodeValues = new List<int>();
            var currentNode = this.head;
            while (currentNode != null)
            {
                nodeValues.Add(currentNode.value);
                currentNode = currentNode.next;
            }

            Console.Write("[");
            foreach (var nodeValue in nodeValues)
            {
                
                Console.Write(nodeValue + " ");
            }
            Console.Write("]");

        }
    }
}
