using AlgorithmsConsole.BinaryTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BST test = new BST(10);

            //BST.Lookup(test, 10);
            //test = BST.Insert(test, 2);
            //test = BST.Insert(test, 20);

            BST.Build(3);
        }
    }
}
