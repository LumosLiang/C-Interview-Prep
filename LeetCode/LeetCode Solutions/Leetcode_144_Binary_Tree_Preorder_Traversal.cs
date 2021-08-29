

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Leetcode_144_Binary_Tree_Preorder_Traversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var res = new List<int>();
            if (root == null)
            {
                return res;
            }
            res.Add(root.val);
            return res.Concat(PreorderTraversal(root.left)).Concat(PreorderTraversal(root.right)).ToList();

        }
    }
}