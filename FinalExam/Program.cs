using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static FinalExam.MyStack;
using Newtonsoft.Json;

namespace FinalExam
{
    //Number 1
    public class MyStack
    {
        public List<int> myStack = new List<int>();

        public void Push(int n)
        {
            myStack.Add(n);
        }

        public int? Peek()
        {
            if (myStack.Count > 0)
            {
                return myStack[myStack.Count - 1];
            }
            else
            {
                return null;
            }
        }

        public int? Pop()
        {
            if (myStack.Count > 0)
            {
                int? r = myStack[myStack.Count - 1];
                myStack.Remove(myStack.Count - 1);
                return r;
            }
            else
            {
                return null;
            }
        }
        //Number 2
        public class MyQueue
        {
            public List<int> myQueue = new List<int>();

            public void Enqueue(int n)
            {
                myQueue.Insert(0, n);
            }

            public int? Peek()
            {
                if (myQueue.Count > 0)
                {
                    return myQueue[0];
                }
                else
                {
                    return null;
                }
            }

            public int? Dequeue()
            {
                if (myQueue.Count > 0)
                {
                    int? r = myQueue[0];
                    myQueue.RemoveAt(0);
                    return r;
                }
                else
                {
                    return null;
                }
            }
        }

        //Number 4

        public enum EColor
        {
            red,
            blue,
            yellow,
            cyan,
            gray,
            purple,
            orange,
            green
        }
        public static List<Node> colorNodes = new List<Node>();

        public class Node : IComparable<Node>
        {
            public EColor nState;

            public List<Edge> edges = new List<Edge>();

            public int minCostToStart;
            public Node nearestToStart;
            public bool visited;

            public Node(EColor nState)
            {
                this.nState = nState;
                this.minCostToStart = int.MaxValue;
            }

            public void AddEdge(int cost, Node connection)
            {
                Edge e = new Edge(cost, connection);
                edges.Add(e);
            }

            public int CompareTo(Node n)
            {
                return this.minCostToStart.CompareTo(n.minCostToStart);
            }
        }


        public class Edge : IComparable<Edge>
        {
            public int cost;
            public Node connectedNode;

            public Edge(int cost, Node connectedNode)
            {
                this.cost = cost;
                this.connectedNode = connectedNode;
            }

            public int CompareTo(Edge e)
            {
                return this.cost.CompareTo(e.cost);
            }
        }

        static public List<Node> GetShortestPathDijkstra()
        {
            DijkstraSearch();
            List<Node> shortestPath = new List<Node> ();
            shortestPath.Add(colorNodes[7]);
            BuildShortestPath(shortestPath, colorNodes[7]);
            shortestPath.Reverse();
            return (shortestPath);
        }

        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if(node.nearestToStart == null)
            {
                return;
            }
            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }

        static private int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        static private void DijkstraSearch()
        {
            Node start = colorNodes[0];

            start.minCostToStart = 0;
            List<Node> prioQueue = new List<Node>();
            prioQueue.Add(start);

            Func<Node, int> nodeOrderBy = NodeOrderBy;

            do
            {
                prioQueue.Sort();

                Node node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (Edge cnn in
                    node.edges.OrderBy(delegate (Edge n) { return n.cost; }))
                {
                    Node childNode = cnn.connectedNode;
                    if (childNode.visited)
                    {
                        continue;
                    }

                    if (childNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < childNode.minCostToStart)
                    {
                        childNode.minCostToStart = node.minCostToStart + cnn.cost;
                        childNode.nearestToStart = node;
                        if (!prioQueue.Contains(childNode))
                        {
                            prioQueue.Add(childNode);
                        }
                    }
                }
                node.visited = true;

                if (node == colorNodes[7])
                {
                    return;
                }
            } while (prioQueue.Any());

        }
        //Number 6
        public class Player
        {
            public string player_name;
            public int level;
            public int hp;
            public List<string> inventory;
            public string license_key;

            private Player()
            {

            }

            private static Player instance = new Player();

            public static Player GetInstance()
            {
                return instance;
            }

            public void OpenPlayerFile(string filename)
            {
                StreamReader input = new StreamReader(filename);
                string sInput = input.ReadToEnd();
                input.Close();

                instance = JsonConvert.DeserializeObject<Player>(sInput);
            }

            public void WritePlayerFile(string filename)
            {
                string sOutput = JsonConvert.SerializeObject(instance);

                StreamWriter output = new StreamWriter(filename);
                output.Write(sOutput);
                output.Close();

            }
        }

        //Number 9
        class DelegateFunctions
        {
            public delegate double MyRounder(double d, int n);
            static void Main(string[] args)
            {
                // create variable of delegate function type 
                MyRounder myRounder;

                // your code here


                myRounder = new MyRounder(delegate (double d, int n) { return Math.Round(d, n); });

                myRounder += delegate (double d, int n) { return Math.Round(d, n); };

                myRounder += (double d, int n) => { return Math.Round(d, n); };

                myRounder += (double d, int n) => Math.Round(d, n);

                myRounder += (d, n) => { return Math.Round(d, n); };

                myRounder += (d, n) => Math.Round(d, n);

                myRounder += new MyRounder(Math.Round);

                myRounder += Math.Round;

                myRounder += new MyRounder(new Func<double, int, double>((double d, int n) => { return Math.Round(d, n); }));

                myRounder += new MyRounder(new Func<double, int, double>(Math.Round));
            }
        }


        internal class Program
        {
            //Number 4
            static void DFS(EColor eState)
            {
                bool[] visited = new bool[colorAGraph.Length];
                DFSUtil(eState, visited);
            }

            static void DFSUtil(EColor v, bool[] visited)
            {
                visited[(int)v] = true;

                Console.Write(v.ToString() + " ");

                int[] thisStateList = colorAGraph[(int)v];
                if (thisStateList != null)
                {
                    foreach (int n in thisStateList)
                    {
                        if (!visited[n])
                        {
                            DFSUtil((EColor)n, visited);
                        }
                    }
                }
            }
            //Number 3
            static int[,] colorMGraph = new[,]
            {
                /*red blue yellow cyan gray purple orange green*/
                /*red*/{-1, 1, -1, -1, 5, -1, -1, -1 },
                /*blue*/ {-1,-1,8,1,-1,-1,-1,-1},
                /*yellow*/{-1,-1,-1,-1,-1,-1,-1,6},
                /*cyan*/ {-1,-1,1,-1,0,-1,-1,-1},
                /*gray*/ {-1,-1,-1,0,-1,-1,1,-1},
                /*purple*/ {-1,-1,1,-1,-1,-1,-1,-1},
                /*orange*/ {-1,-1,-1,-1,-1,1,-1,-1},

                /*green*/ {-1,-1,-1,-1,-1,-1,-1,-1 }
            };
            //Color
            static int[][] colorAGraph = new int[][]
            {
                /*red*/ new int[]{(int)EColor.blue, (int)EColor.gray},
                /*blue*/ new int[]{2, 3},
                /*yellow*/ new int[]{7},
                /*cyan*/ new int[]{1,4},
                /*gray*/ new int[]{3,6},
                /*purple*/ new int[]{2},
                /*orange*/ new int[]{5},

                /*green*/ null
            };
            //Weight
            static int[][] colorWGraph = new int[][]
            {
                /*red*/ new int[]{1, 5},
                /*blue*/ new int[]{8, 1},
                /*yellow*/ new int[]{6},
                /*cyan*/ new int[]{1,0},
                /*gray*/ new int[]{0,1},
                /*purple*/ new int[]{1},
                /*orange*/ new int[]{1},

                /*green*/ null
            };

            static void Main(string[] args)
            {
                //Problem 4
                DFS(EColor.red);

                //Problem 5
                Node node;
                for (int i = 0; i < colorAGraph.Length; i++)
                {
                    node = new Node((EColor)i);
                    colorNodes.Add(node);
                }

                colorNodes[0].AddEdge(1, colorNodes[1]);
                colorNodes[0].AddEdge(5, colorNodes[4]);
                colorNodes[1].AddEdge(8, colorNodes[2]);
                colorNodes[1].AddEdge(1, colorNodes[3]);
                colorNodes[2].AddEdge(6, colorNodes[7]);
                colorNodes[3].AddEdge(1, colorNodes[1]);
                colorNodes[3].AddEdge(0, colorNodes[4]);
                colorNodes[4].AddEdge(0, colorNodes[3]);
                colorNodes[4].AddEdge(1, colorNodes[6]);
                colorNodes[5].AddEdge(1, colorNodes[2]);
                colorNodes[6].AddEdge(1, colorNodes[5]);

                List<Node> dijikstraList = GetShortestPathDijkstra();
                foreach (Node n in dijikstraList)
                {
                    Console.Write(n.nState.ToString() + " ");
                }
            }
        }
    }
}
