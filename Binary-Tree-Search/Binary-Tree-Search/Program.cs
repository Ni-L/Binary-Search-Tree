﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Welcome to Binary Search Tree********");

            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.InsertDataInBST(23);
            binarySearchTree.InsertDataInBST(344);
            binarySearchTree.InsertDataInBST(43);
            binarySearchTree.InsertDataInBST(266);
            binarySearchTree.InsertDataInBST(232);
            binarySearchTree.DisplayDatainBST();
            Console.ReadLine();
        }
    }
}