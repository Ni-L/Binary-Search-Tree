using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Search
{ /// <summary>
  /// Node class is defined as in linkedlist
  /// it will contain two address and one data  one address will point to left node / other address will point to right node
  /// </summary>
    class Node<T>
    {
        public T data;
        public Node<T> left;
        public Node<T> right;


        // constructor to initialize data
        //binary search tree contains definition of three parameters- data, left and right node.

        public Node(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }

    }
}