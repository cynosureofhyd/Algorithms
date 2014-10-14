using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsole.BinaryTrees
{
    public class BST
    {
        int _data;
        private BST left;
        private BST right;
        public BST(int data)
        {
            _data = data;
            left = null;
            right = null;
        }

        public static int maxValue(BST tree)
        {
            BST temp = tree;
            while (temp.right != null)
                temp = temp.right;
            return temp._data;
        }


        public static int minValue(BST tree)
        {
            BST temp = tree;
            while (temp.left != null)
                temp = temp.left;
            return temp._data;
        }

        //Given a binary tree, compute its "maxDepth" -- 
        //the number of nodes along the longest path from the root node down to the farthest leaf node. 
        //The maxDepth of the empty tree is 0, the maxDepth of the tree on the first page is 3.
        public static int MaxDepth(BST tree)
        {
            if (tree == null)
                return 0;
            else
            {
                int leftCount = MaxDepth(tree.left);
                int rightCount = MaxDepth(tree.right);
                if (leftCount > rightCount)
                    return leftCount + 1;
                else
                    return rightCount + 1;
            }
        }

        public static int Size(BST tree)
        {
            if (tree == null)
                return 0;
            return Size(tree.left) + Size(tree.right) + 1;
        }

        // Upto size n, build a balanced binary search tree
        public static BST Build(int n)
        {
            if (n <= 0)
                return new BST(Int32.MinValue);
            List<int> array = new List<int>();
            for(int i = 0; i < n; i++)
            {
                array.Add(i);
            }
            BST result = sortedArrayToBST(array.ToArray(), 0, n - 1);
            return result;
        }

        private static BST sortedArrayToBST(int[] arr, int start, int end) {
              if (start > end) return null;

              // same as (start+end)/2, avoids overflow.
              int mid = start + (end - start) / 2;
              BST node = new BST(arr[mid]);
              node.left = sortedArrayToBST(arr, start, mid-1);
              node.right = sortedArrayToBST(arr, mid+1, end);
              return node;
        }

        public static BST Insert(BST tree, int value)
        {
            if (tree == null)
                return new BST(value);
            else
            {
                if (value <= tree._data)
                    tree.left = Insert(tree.left, value);
                else
                    tree.right = Insert(tree.right, value);
                return tree;
            }
        }

        public static int Lookup(BST tree, int target)
        {
            if (tree == null)
                return Int32.MinValue;
            else
            {
                if (target == tree._data)
                    return 1;
                if (target < tree._data)
                    return Lookup(tree.right, target);
                if (target > tree._data)
                    return Lookup(tree.left, target);
            }
            return Int32.MinValue;  
        }
    }
}
