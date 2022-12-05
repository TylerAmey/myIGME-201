using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryTreeVisualizer;

namespace BTree
{
    public partial class BTreeForm : Form
    {
        public BTreeForm()
        {
            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {
            }

            InitializeComponent();

            this.randomButton.Click += new EventHandler(RandomButton__Click);
            this.unbalancedButton.Click += new EventHandler(UnbalancedButton__Click);
            this.primedButton.Click += new EventHandler(PrimedButton__Click);
            this.button1.Click += new EventHandler(Exercise1__Click);
            this.button2.Click += new EventHandler(Exercise2__Click);
            this.button3.Click += new EventHandler(Exercise3__Click);
            this.button4.Click += new EventHandler(Exercise4__Click);
            this.button5.Click += new EventHandler(Exercise5__Click);
            this.button6.Click += new EventHandler(Exercise6__Click);
            this.button7.Click += new EventHandler(Exercise7__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // give the BTree class objects access to Form1
            BTree.bTreeForm = this;
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RandomButton__Click(object sender, EventArgs e)
        {
            // load a tree with random numbers
            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            for (int i = 0; i < 10; ++i)
            {
                node = new BTree(random.Next(100), root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\nAscending order:";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\nDescending order:";
            BTree.TraverseDescending(root);


            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void UnbalancedButton__Click(object sender, EventArgs e)
        {
            // load a tree in data-ascending order, 
            // which will cause it to be unbalanced and poor-performing
            BTree root = null;
            BTree node;

            this.richTextBox.Clear();

            for (int i = 0; i < 10; ++i)
            {
                node = new BTree(i, root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void PrimedButton__Click(object sender, EventArgs e)
        {
            // Prime a tree to hold alphabetical information

            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            
            node = new BTree("M", null);
            root = node;

            node = new BTree("F", root);
            node = new BTree("C", root);
            node = new BTree("B", root);
            node = new BTree("A", root);
            node = new BTree("E", root);
            node = new BTree("D", root);

            node = new BTree("J", root);
            node = new BTree("I", root);
            node = new BTree("H", root);
            node = new BTree("G", root);
            node = new BTree("L", root);
            node = new BTree("K", root);

            node = new BTree("P", root);
            node = new BTree("O", root);
            node = new BTree("N", root);
            node = new BTree("T", root);
            node = new BTree("S", root);
            node = new BTree("R", root);
            node = new BTree("Q", root);

            node = new BTree("W", root);
            node = new BTree("V", root);
            node = new BTree("U", root);
            node = new BTree("X", root);
            node = new BTree("Y", root);
            node = new BTree("Z", root);

            this.richTextBox.Text += "\n";            
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\n";
            BTree.TraverseDescending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        public static void AddChildNode(BTree newNode, BTree treeNode)
        {
            if(newNode >= treeNode)
            {
                if(treeNode.gteChild == null)
                {
                    treeNode.gteChild = newNode;
                }
                else
                {
                    AddChildNode(newNode, treeNode.gteChild);
                }
            }
            else
            {
                if(treeNode.ltChild == null)
                {
                    treeNode.ltChild = newNode;
                }
                else
                {
                    AddChildNode(newNode, treeNode.ltChild);
                }
            }
        }

        private void Exercise1__Click(object sender, EventArgs e)
        {
            // Exercise #1
            // insert 30 random numbers between 1 and 51

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            // Your code here
            for(int i = 0; i <= 30; i++)
            {
                int randInt = random.Next(1, 52);
                node = new BTree(randInt, root);
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise2__Click(object sender, EventArgs e)
        {
            // Exercise #2
            // prime the tree for numbers between 1 and 51
            // with 7 optimally distributed data points (setting isData = false) 
            // then insert 30 random numbers between 1 and 51

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();


            // Your code here
            node = new BTree(25, null);
            root = node;

            for (int i = 0; i < 30; ++i)
            {
                node = new BTree(random.Next(1, 52), root);
                if(i % 7 == 0)
                {
                    node.isData = false;
                }
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise3__Click(object sender, EventArgs e)
        {
            // Exercise #3
            // insert 15 random uppercase strings

            BTree root = null;
            BTree node;
            Random random = new Random();
            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" };

            this.richTextBox.Clear();

            // Your code here
            for(int i = 0; i <15; ++i)
            {
                int randNum = random.Next(1, 16);
                string randString = alphabet[randNum];
                node = new BTree(randString, root);
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise4__Click(object sender, EventArgs e)
        {
            // Exercise #4
            // prime the tree using the code in Button3_Click()
            // then insert the 15 random uppercase strings from Exercise #3

            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            node = new BTree("H", null);
            root = node;

            // Your code here
            Random random = new Random();
            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" };
            for (int i = 0; i < 15; ++i)
            {
                int randNum = random.Next(1, 16);
                string randString = alphabet[randNum];
                node = new BTree(randString, root);
            }

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\n";
            BTree.TraverseDescending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise5__Click(object sender, EventArgs e)
        {
            // Exercise #5
            // use the code in Button3_Click to add the 26 letters to the tree
            // then remove nodes "C", "I" and "A" 
            // using this code to remove each node:
            //     // create new freestanding node for "C"
            //     nodeToDelete = new BTree("C", null);
            //     BTree.DeleteNode(nodeToDelete, root);
            // add the newline and call BTree.TraverseAscending() after each delete

            this.richTextBox.Clear();

            BTree node = null;
            BTree nodeToDelete = null;
            BTree root = null;

            // Your code here
            Random random = new Random();
            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O","P","Q","R", "S", "T","U", "V", "W","X", "Y", "Z"};
            for (int i = 0; i < 15; ++i)
            {
                int randNum = random.Next(1, 16);
                string randString = alphabet[randNum];
                node = new BTree(randString, root);
            }

            nodeToDelete = new BTree("C", null);
            BTree.DeleteNode(nodeToDelete, root);
            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);
            nodeToDelete = new BTree("I", null);
            BTree.DeleteNode(nodeToDelete, root);
            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);
            nodeToDelete = new BTree("A", null);
            BTree.DeleteNode(nodeToDelete, root);
            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }



        private void Exercise6__Click(object sender, EventArgs e)
        {
            // Exercise #6
            // there are operator overloads to compare 2 BTree objects for BTree.data being string or int
            // enhance the overloads to support the Person object and compare using Person.age using:                
            //     if (a.data.GetType() == typeof(Person))


            // create at least 15 new Person objects which correspond to members of your family
            // insert them into the tree starting with yourself
            Person me = new Person("Tyler", 19);
            Person joe1 = new Person("Joe1", 21);
            Person joe2 = new Person("Joe2", 24);
            Person joe3 = new Person("Joe3", 28);
            Person joe4 = new Person("Joe4", 11);
            Person joe5 = new Person("Joe5", 5);
            Person joe6 = new Person("Joe6", 67);
            Person joe7 = new Person("Joe7", 90);
            Person joe8 = new Person("Joe8", 100);
            Person joe9 = new Person("Joe9", 4);
            Person joe10 = new Person("Joe10",32);
            Person joe11 = new Person("Joe11", 45);
            Person joe12 = new Person("Joe12", 46);
            Person joe13 = new Person("Joe13", 237);
            Person joe14 = new Person("Joe14", 1);
            List<Person> peopleList = new List<Person>();
            peopleList.Add(me);
            peopleList.Add(joe1);
            peopleList.Add(joe2);
            peopleList.Add(joe3);
            peopleList.Add(joe4);
            peopleList.Add(joe5);
            peopleList.Add(joe6);
            peopleList.Add(joe7);
            peopleList.Add(joe8);
            peopleList.Add(joe9);
            peopleList.Add(joe10);
            peopleList.Add(joe11);
            peopleList.Add(joe12);
            peopleList.Add(joe13);
            peopleList.Add(joe14);
            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            node = new BTree(me, null);
            root = node;
            // the Person class is defined below
            Person person = null;

                // Your code here
                foreach (Person p in peopleList)
            {
                if(p == me)
                {
                    continue;
                }
                else
                {
                    if (node.data.GetType() == typeof(Person))
                    {
                        node = new BTree(p, root);
                    }
                }
            }


            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise7__Click(object sender, EventArgs e)
        {
            // Exercise #7
            // given the age range of people in Exercise #6, 
            // prime the tree with nodes containing Person objects (set isData = false for the seed nodes)
            // containing the optimal ages to balance the tree
            Person me = new Person("Tyler", 19);
            Person joe1 = new Person("Joe1", 21);
            Person joe2 = new Person("Joe2", 24);
            Person joe3 = new Person("Joe3", 28);
            Person joe4 = new Person("Joe4", 11);
            Person joe5 = new Person("Joe5", 5);
            Person joe6 = new Person("Joe6", 67);
            Person joe7 = new Person("Joe7", 90);
            Person joe8 = new Person("Joe8", 100);
            Person joe9 = new Person("Joe9", 4);
            Person joe10 = new Person("Joe10", 32);
            Person joe11 = new Person("Joe11", 45);
            Person joe12 = new Person("Joe12", 46);
            Person joe13 = new Person("Joe13", 237);
            Person joe14 = new Person("Joe14", 1);
            List<Person> peopleList = new List<Person>();
            peopleList.Add(me);
            peopleList.Add(joe1);
            peopleList.Add(joe2);
            peopleList.Add(joe3);
            peopleList.Add(joe4);
            peopleList.Add(joe5);
            peopleList.Add(joe6);
            peopleList.Add(joe7);
            peopleList.Add(joe8);
            peopleList.Add(joe9);
            peopleList.Add(joe10);
            peopleList.Add(joe11);
            peopleList.Add(joe12);
            peopleList.Add(joe13);
            peopleList.Add(joe14);
            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            node = new BTree(joe3, null);
            root = node;

            // the Person class is defined below
            Person person = null;

            // Your code here
            foreach (Person p in peopleList)
            {
                node = new BTree(p, root);
                if(p.age % 3 == 0)
                {
                    node.isData = false;
                }
            }

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }
        public static bool operator == (BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data == (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = ((string)a.data == (string)b.data);
                }

                if (a.data.GetType() == typeof(Person))
                {
                    Person ap = (Person)a.data;
                    Person bp = (Person)b.data;

                    returnVal = (ap.age == bp.age);
                }
            }
            catch
            {
                returnVal = (a == (object)b);
            }

            return (returnVal);
        }

        public static bool operator != (BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data != (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = ((string)a.data != (string)b.data);
                }

                if (a.data.GetType() == typeof(Person))
                {
                    Person ap = (Person)a.data;
                    Person bp = (Person)b.data;

                    returnVal = (ap.age != bp.age);
                }
            }
            catch
            {
                returnVal = (a != (object)b);
            }

            return (returnVal);
        }

        public static bool operator < (BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data < (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = (((string)a.data).CompareTo((string)b.data) < 0);
                }

                if (a.data.GetType() == typeof(Person))
                {
                    Person ap = (Person)a.data;
                    Person bp = (Person)b.data;

                    returnVal = (ap.age < bp.age);
                }
            }
            catch
            {
                returnVal = false;
            }

            return (returnVal);
        }

        public static bool operator > (BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data > (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = (((string)a.data).CompareTo((string)b.data) > 0);
                }

                if (a.data.GetType() == typeof(Person))
                {
                    Person ap = (Person)a.data;
                    Person bp = (Person)b.data;

                    returnVal = (ap.age > bp.age);
                }
            }
            catch
            {
                returnVal = false;
            }

            return (returnVal);
        }

        public static bool operator >= (BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data >= (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = (((string)a.data).CompareTo((string)b.data) >= 0);
                }

                if (a.data.GetType() == typeof(Person))
                {
                    Person ap = (Person)a.data;
                    Person bp = (Person)b.data;

                    returnVal = (ap.age >= bp.age);
                }
            }
            catch
            {
                returnVal = false;
            }

            return (returnVal);
        }

        public static bool operator <= (BTree a, BTree b)
        {
            bool returnVal = false;

            try
            {
                if (a.data.GetType() == typeof(int))
                {
                    returnVal = ((int)a.data <= (int)b.data);
                }

                if (a.data.GetType() == typeof(string))
                {
                    returnVal = (((string)a.data).CompareTo((string)b.data) <= 0);
                }

                if (a.data.GetType() == typeof(Person))
                {
                    Person ap = (Person)a.data;
                    Person bp = (Person)b.data;

                    returnVal = (ap.age <= bp.age);
                }
            }
            catch
            {
                returnVal = false;
            }

            return (returnVal);
        }
    }

}
