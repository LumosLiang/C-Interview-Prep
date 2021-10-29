using System.Collections.Generic;


namespace LeetCode
{
    public class Leetcode_102_Binary_Tree_Level_Order_Traversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var size = queue.Count;
                var oneResult = new List<int>();
                for (int s = 0; s < size; s++)
                {
                    var cur = queue.Dequeue();
                    oneResult.Add(cur.val);

                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }

                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                }
                result.Add(oneResult);
            }

            return result;

        }
    }
}
