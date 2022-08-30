using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Design_Type.Generics
{
    // all instance must have the same type
    class Node<T> {
        public T value;
        public Node<T> next;

        public Node(T val) : this(val, null)
        {

        }

        public Node(T val, Node<T> nxt) {
            value = val;
            next = nxt;
        }
    }


    // Node val is generic
    // but next node can be any type.
    internal class Node {

        Node next;
        public Node(Node nxt) {
            next = nxt;
        }
    }

    class TypeNode<T>: Node
    {
        public T value;

        public TypeNode(T val) : this(val, null) { }

        public TypeNode(T val, Node nxt):base(nxt)
        {
            value = val;
        }
    }

    class GenericInheritanceTest { 
        public static void DifferentDataLinkedList()
        {
            Node head = new TypeNode<Char>('.');
            head = new TypeNode<DateTime>(DateTime.Now, head);
            head = new TypeNode<String>("Today is ", head);
            Console.WriteLine(head.ToString());
        }
    }
}
