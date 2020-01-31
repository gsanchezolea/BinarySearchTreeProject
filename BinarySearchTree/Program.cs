using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bST = new BST();
            bST.AddToBST(20);
            bST.AddToBST(45);
            bST.AddToBST(15);
            bST.AddToBST(48);
            bST.AddToBST(42);
            //Console.WriteLine(bST.SearchBST(42));
            Console.WriteLine(bST.SearchBST2(43));
            Console.ReadLine();
           
        }
    }
}
