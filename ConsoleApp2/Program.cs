using System;

namespace ConsoleApp2
{
    public abstract class Furniture 
    {
        public string color  { get; set; }
        public int price  { get; set; }
        public Furniture(string c, int pr)
        {
            this.color = c;
            this.price = pr;
        }
       public abstract Furniture Clone();
      
    }

    public class Sofa : Furniture
    {
        public string material { get; set; }
        public Sofa(string m, string c, int pr)
            :base(c, pr)
        {
            this.material = m;
        }
        public override Furniture Clone()
        {
            return new Sofa(material, color, price);
        }

    }
    public class Table : Furniture
    {
        public int places { get; set; }
        public Table (int p, string c, int pr)
            : base(c, pr)
        {
            this.places = p;
        }
        public override Furniture Clone()
        {
            return new Table (places, color, price);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Sofa sofa = new Sofa("leather", "brown", 1000);
            Sofa sofa1 = sofa.Clone() as Sofa ;
            Console.WriteLine(sofa1.color);
            Console.WriteLine(sofa1.price);
            Console.WriteLine(sofa1.material);
        }
    }
}
