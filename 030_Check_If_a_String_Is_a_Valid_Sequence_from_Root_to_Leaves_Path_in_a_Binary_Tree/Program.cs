using System;

namespace _030_Check_If_a_String_Is_a_Valid_Sequence_from_Root_to_Leaves_Path_in_a_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a binary tree where each path going from the root to any leaf form a valid sequence, 
               check if a given string is a valid sequence in such binary tree. 

             * We get the given string from the concatenation of an array of integers arr and the concatenation of all 
               values of the nodes along a path results in a sequence in the given binary tree.

             * Example 1:

                       0
                     /   \
                    1      0
                   / \     /
                  0   0   0
                  \   / \
                   0  0  0

               Input: root = [0,1,0,0,1,0,null,null,1,0,0], arr = [0,1,0,1]
               Output: true

               Explanation: 
               The path 0 -> 1 -> 0 -> 1 is a valid sequence (green color in the figure). 

               Other valid sequences are: 
               0 -> 1 -> 1 -> 0 
               0 -> 0 -> 0
             */

        }
    }

    /**
    * Definition for a binary tree node.
    */

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public bool IsValidSequence(TreeNode root, int[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
