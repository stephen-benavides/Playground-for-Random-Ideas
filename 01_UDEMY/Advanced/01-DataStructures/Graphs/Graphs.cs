using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced._01_DataStructures.Graphs
{
    class Graphs
    {
        //Not working fine atm, need to look closer
    }



    class Node
    {
        public int Value;
        public Node Next;

        public Node(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
    class Graph
    {
        // Undirected, unweighted graph 

        public int NumberOfNodes { get; set; }
        public Dictionary<Node?, List<Node?>> AdjacentList;

        public Node Node;

        public Graph()
        {

            this.NumberOfNodes = 0;
            this.AdjacentList = new Dictionary<Node?, List<Node?>>();
            this.Node = null;
        }

        public void AddVertex(Node node)
        {
            // Creating empty list 
            this.AdjacentList[node] = new List<Node?>();
            this.NumberOfNodes++;
        }

        public void AddEdge(Node node1, Node node2)
        {
            //Undirected Graph
            this.AdjacentList[node1].Add(node2);
            this.AdjacentList[node1].Add(node1);
        }

        public void ShowConnections()
        {
            var nodeConnections = new List<List<Node>>();
            var allNodes = this.AdjacentList.Keys;
            foreach (var node in allNodes)
            {
                nodeConnections.Add(this.AdjacentList[node]);
                var connections = "";
                foreach (var nodeConnection in nodeConnections)
                {
                    connections += nodeConnection + "";
                }

                Console.WriteLine(node + "--->" + connections);
            }
        }
    }


    public class ProgramCaller
    {
        public static void MainCaller(string[] args)
        {
            Graph graph = new Graph();

            Node zero = new Node(0);
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);


            graph.AddVertex(zero);
            graph.AddVertex(one);
            graph.AddVertex(two);
            graph.AddVertex(three);
            graph.AddVertex(four);
            graph.AddVertex(five);
            graph.AddVertex(six);

            graph.AddEdge(three, one);
            graph.AddEdge(three, four);
            graph.AddEdge(four, two);
            graph.AddEdge(four, five);
            graph.AddEdge(one, two);
            graph.AddEdge(one, zero);
            graph.AddEdge(zero, two);
            graph.AddEdge(six, five);


            graph.ShowConnections();

        }
    }
}
