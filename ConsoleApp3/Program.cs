using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var race = new Race();
           Console.WriteLine("To continue, type '+', plesse");
            int k = 0;
            while (k == 0)
            {
                var elem = Console.ReadLine();
                if (elem == "+")
                {
                    race.Start();
                    k++;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
            race.Dispose();
        }
        
    }
}
