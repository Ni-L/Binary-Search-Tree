using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Search
{   /// <summary>
    /// Class Contain GEneric method
    /// Generic Binary search tree is defined
    /// Due to generic class, Icomparable method is defined to use CompareTo inside the program
    /// </summary>
    class BinarySearchTree<T> where T : IComparable
    {
        //creating a object of Node class, called root which will save the first data coming from the user
        public Node<T> root;
        int leftNodeCount = 0;
        int rightNodeCount = 0;


        // Inserting data in Binary Search Tree
        //Data to be inserted in (data)
        public int InsertDataInBST(T data)
        {
            //Creating and instatiating node with data in constructor
            //now we have to point node to correct addresss so that condition of Binary search tree is satisfied
            //Creating object node 
            Node<T> node = new Node<T>(data);

            //when there is no initial data and root is null, first value is added in root.
            if (root == null)
            {
                root = node;
            }
            else
            {
                //Create current position node is defined which have the value of root element.
                Node<T> currentPosition = root;
                //loop is initialized to add value in binary search tree
                while (true)
                {
                    //current position is assigned to parent node
                    //When current position this is done because parent node will contain the data of currentposition, where as current position will be changed

                    Node<T> parent = currentPosition;
                    //when data is less than the data in root, currentPosition node will point to left direction
                    if (currentPosition.data.CompareTo(data) > 0)
                    {
                        currentPosition = currentPosition.left;

                        //parent node is used to point to left direction and add  node with data.
                        if (currentPosition == null)
                        {
                            parent.left = node;
                            break;
                        }
                    }
                    else
                    {
                        //when data is greater than right position, than root node will point to right direction
                        //address of right node is passed in current position and currentPosition is changed
                        //if right node is null, then parent node is used to assign value at right.
                        currentPosition = currentPosition.right;
                        if (currentPosition == null)
                        {
                            parent.right = node;
                            break;
                        }
                    }
                }
            }
            return 0;
        }
        /// <summary>
        /// Displaying the data in binary search tree in sorted manner
        /// for displaying the data in sorted manner, printing should start from leftmost leaf node.
        /// </summary>
        public void DisplayDatainBST()
        {
            //parent node is defined, which helps in printing values when coming out of recursion in function
            Node<T> parent = root;
            //if pointer to left node is not null, then root is changed to left value, and parent node still represents root.
            //displaydatainBST is again called and root is changed to represent left node.
            //this recursion continues until left most node becomes null and value is printed for that particular parent node.
            if (root.left != null)
            {
                leftNodeCount++;
                parent = root;
                root = root.left;
                DisplayDatainBST();
            }
            Console.WriteLine("Data in sorted manner from :\t" + parent.data);
            //after printing first value for which left node is null
            //and checked for right node
            if (root.right != null)
            {
                rightNodeCount++;
                root = root.right;
                DisplayDatainBST();
            }
        }
        public void CountOfNodes()
        {
            //variables are defined in  class for left node count and right node count
            //counters for each node are incremented when displaying the value.
            //when condition for left node is not null is called then left counter is incremented, otherwise right counter is incremented
            Console.WriteLine("Count for Left nodes are\t" + leftNodeCount);
            Console.WriteLine("Count for Right nodes are\t" + rightNodeCount);
        }
        //Seraching For list
        public void SearchInBST(Node<T> root, T searchValue)
        {
            //if root is not there, then either the bst is null or after iteration, particular search value is not in bst.
            if (root == null)
            {
                Console.WriteLine("Value is not present in the binary search tree");
                return;
            }
            //after recursion, everytime root value is changed and root value is checked to be equal to search value
            if (root.data.Equals(searchValue))
            {
                Console.WriteLine("searched value is there in the binary search tree");
                return;
            }
            //if root data is bigger than search value, then root is pointed to left node and left node is passed to same method, by doing recursion
            //if there is no left node, then left will point null and value is not present
            //if  new root is matched with search value then message is printed
            if (root.data.CompareTo(searchValue) > 0)
            {
                root = root.left;
                SearchInBST(root, searchValue);
            }
            //when root element is less then the search value, then root is pointed to right node and passed to same method, doing recursion
            else
            {
                root = root.right;
                SearchInBST(root, searchValue);
            }
        }
    }
}