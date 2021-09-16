
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_98_Validate_Binary_Search_Tree

    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValid(root, long.MinValue, long.MaxValue);
        }

        private bool IsValid(TreeNode root, long left, long right)
        {
            if (root is null) return true;
            if (root.val <= left || root.val >= right) return false;

            var l = IsValid(root.left, left, root.val);
            var r = IsValid(root.right, root.val, right);

            return (l && r);
        }
    }
}

