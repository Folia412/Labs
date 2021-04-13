namespace ConsoleApp1
{
    public class List 
    {
        Node head;
        public string add_elem(string value)
        {
            Node node = new Node(value);
            node.next = head;
            head = node;
            string f = node.data;
            return f;
        }
        public bool Equal(List l, List f)
        {
            Node now = l.head;
            Node cur = f.head;
            while (now != null && cur != null)
            {                  
                if (now.data != cur.data)
                    {
                        return false;
                    }
                    now = now.next;
                    cur = cur.next;
            }
            return true;
        }

        public int Amount(string value)
        {
            Node now = head;
            int z = 0;
            while(now!=null)
            {
                if (now.data == value)
                {
                    z++;
                }
                now = now.next;
            }
            return z;

        }
    }   
}
