

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Leetcode_590_N_ary_Tree_Postorder_Traversal
    {
        public IList<int> Postorder(Node root)
        {
            var r = helper(root).ToList();
            r.Reverse();
            return r;
        }

        public IList<int> helper(Node root)
        {

            var res = new List<int>();
            if (root != null)
            {
                res.Add(root.val);

                for (int idx = root.children.Count - 1; idx >= 0; idx--)
                {
                    res.AddRange(helper(root.children[idx]));
                }
            }
            return res;
        }
    }
}
