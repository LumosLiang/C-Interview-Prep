
using System.Collections.Generic;

namespace LeetCode
{
    public class LRUCache
    {
        public int _capacity;
        public Dictionary<int, DoublyLinkedListNode> _hash;
        public DoublyLinkedListNode _head;
        public DoublyLinkedListNode _tail;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
            _hash = new Dictionary<int, DoublyLinkedListNode>();
            _head = new DoublyLinkedListNode();
            _tail = new DoublyLinkedListNode();

            _head.next = _tail;
            _tail.pre = _head;
        }

        public int Get(int key)
        {
            if (_hash.ContainsKey(key))
            {
                var node = _hash[key];
                // extract from the linkedlist
                TakeOut(ref node);
                // append to the head
                AppendStart(ref node);
                // re-hash
                _hash[key] = node;
                return node.val;
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            if (_hash.ContainsKey(key))
            {
                var node = _hash[key];
                node.val = value;
                TakeOut(ref node);
                AppendStart(ref node);
                _hash[key] = node;
            }
            else
            {
                if (_hash.Count == _capacity)
                {
                    // evic the end
                    var evicNode = _tail.pre;
                    TakeOut(ref evicNode);
                    _hash.Remove(evicNode.key);
                    // delete its hash
                }

                // append this to the start
                var newNode = new DoublyLinkedListNode(value, key);
                AppendStart(ref newNode);
                _hash[key] = newNode;
            }

        }

        public void AppendStart(ref DoublyLinkedListNode node)
        {
            var origFirst = _head.next;
            _head.next = node;
            node.pre = _head;

            node.next = origFirst;
            origFirst.pre = node;

        }

        public void TakeOut(ref DoublyLinkedListNode node)
        {
            node.pre.next = node.next;
            node.next.pre = node.pre;
            node.next = null;
            node.pre = null;
        }

    }

    public class DoublyLinkedListNode
    {
        public int val;
        public int key;
        public DoublyLinkedListNode pre;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode(int val = -1, int key = -1, DoublyLinkedListNode pre = null, DoublyLinkedListNode next = null)
        {
            this.val = val;
            this.key = key;
            this.pre = pre;
            this.next = next;
        }
    }

}

