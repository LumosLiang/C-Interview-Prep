
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Leetcode_429_N_ary_Tree_Level_Order_Traversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {

            var res = new List<IList<int>>();
            if (root == null) return res;

            var q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Any())
            {
                var temp = new Queue<Node>();
                var temp_val = new List<int>();

                while (q.Any())
                {
                    var node = q.Dequeue();
                    temp_val.Add(node.val);
                    if (node.children.Any())
                    {
                        foreach (var c in node.children)
                        {
                            temp.Enqueue(c);
                        }
                    }
                }
                res.Add(temp_val);
                q = temp;
            }
            return res;
        }
    }
}
