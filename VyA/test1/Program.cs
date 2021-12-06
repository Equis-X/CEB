using System;
using vector;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte y: ");
            int y = int.Parse(Console.ReadLine());
            Vector vector = new Vector(x,y);
            Console.WriteLine(vector+" "+vector.Magnitude());
        }
    }
}
