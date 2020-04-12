using System;

namespace _011_Diameter_of_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a binary tree, you need to compute the length of the diameter of the tree. 
             * The diameter of a binary tree is the length of the longest path between any two nodes in a tree. 
             * This path may or may not pass through the root.
             */

            var testData = new TreeNode(1);
            testData.left = new TreeNode(2);
            testData.right = new TreeNode(3);

            testData.left.left = new TreeNode(4);
            testData.left.right = new TreeNode(5);

            // Return 3, which is the length of the path [4,2,1,3] or [5,2,1,3].

            var solution = new Solution();
            var result = solution.DiameterOfBinaryTree(testData);

            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            throw new NotImplementedException();
        }
    }

    /*
     * Definition for a binary tree node.
     */
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
