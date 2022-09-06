using System.Collections.Generic;

namespace LeetCode
{
    public class MyQueue
    {

        private Stack<int> s1;
        private Stack<int> s2;

        

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
            if (s2.Count == 0)
                Transfer(); ;
            return s2.Pop();
        }

        public int Peek()
        {
            if (s2.Count == 0) 
                Transfer();
            return s2.Peek();
        }

        private void Transfer()
        {
            while (s1.Count != 0)
                s2.Push(s1.Pop());
        }

        public bool Empty()
        {
            if (s1.Count == 0 && s2.Count == 0) return true;
            else return false;
        }
    }
}

