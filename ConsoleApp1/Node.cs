namespace ConsoleApp1
{
    public class Node
    {
        public Node(string value)
        {
            data = value;
        }
        public string data { get; set; }
        public Node next { get; set; }
    }
}
