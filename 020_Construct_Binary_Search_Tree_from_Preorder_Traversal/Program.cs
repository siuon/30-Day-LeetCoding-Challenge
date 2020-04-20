using System;
using System.Linq;

namespace _020_Construct_Binary_Search_Tree_from_Preorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return the root node of a binary search tree that matches the given preorder traversal.
             
             * (Recall that a binary search tree is a binary tree where for every node, 
               any descendant of node.left has a value < node.val, 
               and any descendant of node.right has a value > node.val.  
               Also recall that a preorder traversal displays the value of the node first, then traverses node.left, 
               then traverses node.right.)

             * Input: [8,5,1,7,10,12]
             * Output: [8,5,10,1,7,null,12]

             * Note: 
             * 1. 1 <= preorder.length <= 100
             * 2. The values of preorder are distinct.
             */

            var preorder = new int[] { 8, 5, 1, 7, 10, 12 };
            var solution = new Solution();

            var resultNode = solution.BstFromPreorder(preorder);
        }
    }

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            TreeNode rootNode = null;

            foreach (var item in preorder)
            {
                SetNode(ref rootNode, item);
            }

            return rootNode;
        }

        private void SetNode(ref TreeNode currentNode, int num)
        {
            if (currentNode == null)
            {
                currentNode = new TreeNode(num);

                return;
            }
            else if (currentNode.val < num)
            {
                SetNode(ref currentNode.right, num);
            }
            else
            {
                SetNode(ref currentNode.left, num);
            }
        }
    }
}
