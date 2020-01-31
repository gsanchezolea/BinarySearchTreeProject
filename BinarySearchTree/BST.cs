using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BST
    {
        public Node root = null;
        


        public BST()
        {

        }

        public void AddToBST(int data)
        {

            if (root == null)
            {
                root = new Node(data);
            }
            else
            {
                Node current = root;
                bool haveAddedItem = false;
                while (!haveAddedItem)
                {
                    if (data > current.data)
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = new Node(data);
                            haveAddedItem = true;
                        }
                        else
                        {
                            current = current.rightChild;
                        }
                    }
                    else
                    {
                        if (current.leftChild == null)
                        {
                            current.leftChild = new Node(data);
                            haveAddedItem = true;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }
                }

            }
        }
        public bool SearchBST(int data)
        {
            bool result = false;

            if (root == null)
            {
                return false;
            }
            else
            {
                Node current = root;


                while (!result)
                {
                    if (current == (null))
                    {
                        result = false;
                    }

                    if (data == current.data)
                    {

                        result = true;
                    }
                    else if (data > current.data)
                    {
                        current = current.rightChild;

                    }
                    else
                    {
                        current = current.leftChild;
                    }

                }
            }
            return result;
        }
        public bool SearchBST2(int data)
        {
            bool resultReturned = false;
            if (root == null)
            {
                return resultReturned;
            }
            else
            {
                Node current = root;
                bool foundItem = false;
                while (!foundItem)
                {
                    if (data > current.data)
                    {
                        if (current.rightChild == null)
                        {                            
                            foundItem = true;
                            resultReturned = !foundItem;
                        }
                        else
                        {
                            current = current.rightChild;
                        }
                    }
                    else if(data < current.data)
                    {
                        if (current.leftChild == null)
                        {                            
                            foundItem = true;
                            resultReturned = !foundItem;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }
                    else
                    {
                        foundItem = true;
                        resultReturned = foundItem;
                    }
                }

            }
            return resultReturned;
        }
    }
}

