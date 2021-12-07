using System;
using vector;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Inserte valor {0}: ",i+1);
                nums[i] = int.Parse(Console.ReadLine());
            }
            Vector vector1 = new Vector(nums[0],nums[1]);
            Vector vector2 = new Vector(nums[2],nums[3]);
            Console.WriteLine("Vector 1: "+vector1+" "+vector1.Magnitude()+"\n"+
            "Vector 2: "+vector2+" "+vector2.Magnitude()+"\n"+
            "Producto Punto: "+vector1.DotProduct(vector2));
        }
    }
}
