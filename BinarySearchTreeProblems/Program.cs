﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            {
                BinarySearchTree<int> tree = new BinarySearchTree<int>(56);
                Console.WriteLine("Welcome to the Binary Search Problems:");
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Please select given options");
                    Console.WriteLine("1.Insert value in BST\n" +
                        "2.Display\n");

                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter number of node wanted to inserted");
                            int node = Convert.ToInt32(Console.ReadLine());
                            if (node == 0)
                            {
                                return;
                            }
                            for (int i = 1; i <= node; i++)
                            {
                                Console.Write("Enter the element to be inserted: ");
                                int data = Convert.ToInt32(Console.ReadLine());
                                tree.Insert(data);
                            }
                            Console.Write("\nPress any key to continue...... ");
                            break;
                        case 2:
                            Console.Clear();
                            tree.Display();
                            Console.Write("\nPress any key to continue...... ");
                            break;
                    }
                }
            }
        }
    }
}
