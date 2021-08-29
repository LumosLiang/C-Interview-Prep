using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_589_N_ary_Tree_Preorder_Traversal
    {

        public IList<int> Preorder(Node root)
        {
            var res = new List<int>();
            if (root != null)
            {
                res.Add(root.val);

                for (int idx = 0; idx < root.children.Count; idx++)
                {
                    res.AddRange(Preorder(root.children[idx]));
                }
            }
            return res;

        }
    }
}
