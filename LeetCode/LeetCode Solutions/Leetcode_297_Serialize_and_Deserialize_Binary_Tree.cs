using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Leetcode_297_Serialize_and_Deserialize_Binary_Tree
    {
        public string serialize(TreeNode root)
        {

            if (root is null) return "";

            var q = new Queue<TreeNode>();
            var sb = new StringBuilder();

            q.Enqueue(root);

            while (q.Count != 0)
            {
                var temp = new Queue<TreeNode>();
                var isEmpty = true;
                while (q.Count != 0)
                {
                    var curr = q.Dequeue();

                    if (curr.val == 1001) sb.Append('+');
                    else sb.Append(curr.val.ToString());
                    sb.Append(';');

                    if (curr.left != null)
                    {
                        temp.Enqueue(curr.left);
                        isEmpty = false;
                    }
                    else
                        temp.Enqueue(new TreeNode(1001));

                    if (curr.right != null)
                    {
                        temp.Enqueue(curr.right);
                        isEmpty = false;
                    }
                    else
                        temp.Enqueue(new TreeNode(1001));
                }
                if (isEmpty) break;
                q = temp;
            }
            return sb.ToString().TrimEnd('-');
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {

            if (data.Length == 0) return null;
            string[] dataList = data.Split(';');

            var root = new TreeNode(Convert.ToInt32(dataList[0]));

            var hash = new Dictionary<int, TreeNode>();
            hash.Add(0, root);

            for (int i = 0; i < dataList.Length; i++)
            {
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (hash[i] == null)
                {
                    hash[left] = null;
                    hash[right] = null;
                }
                else
                {
                    var curr = hash[i];
                    if (left < dataList.Length && dataList[left] != "+")
                    {
                        var leftNode = new TreeNode(Convert.ToInt32(dataList[left]));
                        hash[left] = leftNode;
                        curr.left = leftNode;
                    }
                    else
                    {
                        hash[left] = null;
                    }

                    if (right < dataList.Length && dataList[right] != "+")
                    {
                        var rightNode = new TreeNode(Convert.ToInt32(dataList[right]));
                        hash[right] = rightNode;
                        curr.right = rightNode;
                    }
                    else
                    {
                        hash[right] = null;
                    }
                }
            }
            return root;
        }
    }
}

