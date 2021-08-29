using System;

namespace LeetCode
{
    public class Leetcode_104_Maximum_Depth_of_Binary_Tree

    {
        public int MaxDepth(TreeNode root)
        {

            if (root is null) return 0;

            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
}