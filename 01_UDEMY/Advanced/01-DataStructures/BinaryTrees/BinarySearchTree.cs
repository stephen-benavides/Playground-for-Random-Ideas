using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._01_DataStructures.BinaryTrees
{

#nullable enable
    class Node
    {
        public int? Value;
        public Node? Left;
        public Node? Right;

        public Node(int? value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
    class BinarySearchTree
    {
        public Node? Root;

        public BinarySearchTree()
        {
            this.Root = null;
        }

        public Node? Insert(int value)
        {
            var newNode = new Node(value);
            // If the root is empty
            if (this.Root == null)
                this.Root = newNode;
            else
            {
                var currentNode = this.Root;
                while (true) //Keep looping every time, do not forget to exit out of the loop 
                {
                    //Condition is to traverse over the true 
                    if (value < currentNode.Value)//Go Left 
                    {
                        if (currentNode.Left == null)//Check if there is no element to the left 
                        {
                            currentNode.Left = newNode;
                            return currentNode.Left;  // return to here to exit out of the while loop, which is necessary to stop looping forever
                        }
                        //else update and shift over to the next node
                        currentNode = currentNode.Left;
                    }
                    else //if value is greater 
                    {
                        //right 
                        if (currentNode.Right == null)
                        {
                            currentNode.Right = newNode;
                            return currentNode.Right;
                        }
                        //if there is something in it then 
                        currentNode = currentNode.Right; // Move to the next node 
                    }

                }
            }

            return this.Root;
        }

        //public Node LookUp(int value)
        public bool LookUp(int value)
        {
            /*
            var currentNode = this.Root;
            if (currentNode == null)
                throw new ArgumentNullException("NULL");
            if (currentNode.Left == null || currentNode.Right == null)
                return currentNode;
            if (currentNode.Value == value)
                return this.Root;

            while (true)
            {
                if (value < currentNode.Value)
                {
                    if (currentNode.Left == null)
                        return null;//throw new ArgumentNullException("Does not exist");
                    if (currentNode.Left.Value == value)
                        return currentNode.Left;
                    currentNode = currentNode.Left;
                }
                else if (value > currentNode.Value)
                {
                    if (currentNode.Right == null)
                        return null; //throw new ArgumentNullException("Does not exist");
                    if (currentNode.Right.Value == value)
                        return currentNode.Right;
                    currentNode = currentNode.Right;
                }

            }
            */
            var currentNode = this.Root;
            if (this.Root == null)
                return false;
            // Loop and chane the pointer if right or left, if the current node is equal to the value then return true 
            while (currentNode != null)
            {
                if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                }
                else if (value > currentNode.Value)
                {
                    currentNode = currentNode.Right;
                }
                else if (value == currentNode.Value)
                {
                    return true;
                }
            }
            //return this.Root;
            return false;
        }

        //remove - it is advance so it is considered optional as we are not going to find it in an interview 
        public void Remove(int value)
        {

        }

        public override string ToString()
        {
            String values = String.Format("Root: {0}, Left: {1}, Right: {2}", Root.Value, Root.Right, Root.Left);
            return values;
        }
    }


    /// <summary>
    /// Main Program Caller
    /// </summary>
    public class ProgramCaller
    {
        public static void MainCaller(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(55);
            tree.Insert(44);
            tree.Insert(44);
            tree.Insert(99);
            tree.Insert(105);
            Console.WriteLine(tree.LookUp(4));
            //Console.WriteLine(tree);
            //Console.WriteLine(tree.Root.Right.Right);
        }
    }
}
