
using System.Collections.Generic;

namespace LeetCode
{
    public class MyQueue
    {

        private readonly Stack<int> s1;
        private readonly Stack<int> s2;

        public MyQueue()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        public void Push(int x)
        {
            s1.Push(x);
        }

        public int Pop()
        {
            Peek();
            return s2.Pop();
        }

        public int Peek()
        {
            if (s2.Count == 0)
            {
                while (s1.Count != 0)
                {
                    s2.Push(s1.Pop());
                }
            }
            return s2.Peek();
        }

        public bool Empty()
        {
            if (s1.Count == 0 && s2.Count == 0) return true;
            else return false;
        }
    }
}

