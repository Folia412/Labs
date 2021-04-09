using System;
using System.Collections;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            var A = new List();
            A.add_elem("k");
            A.add_elem("f");
            A.add_elem("o");
            A.add_elem("n");
        }
    }
    public class Node
    {
        public Node(string value)
        {
            data = value;
        }
        public string data { get; set; }
        public Node next { get; set; }
    }
    public class List 
    {
        Node head;
        Node tail;
        int s;
  

        public string add_elem(string value)
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
            }
            tail = node;
            s++;
            string f = node.data;
            return f;
        }
        public bool Equal(List l)
        {
            if (head != null && tail != null)
            {
                if (l.head.data == l.tail.data)
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public int Amount(List l)
        {
            Node now = head;
            int z = 0;
            for (int i = 0; i < s; i++)
            {
                if (now.data == "f")
                {
                    z++;
                }
                now = now.next;
            }
            return z;

        }
    }   
}
