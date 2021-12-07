using System;
using vector._3;

namespace ConsoleVec
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"De el numero {i}");
                nums[i] = int.Parse(Console.ReadLine());
            }
            Vector vector1 = new Vector(nums[0],nums[1]);
            Vector vector2 = new Vector(nums[2],nums[3]);
            Console.WriteLine("Vector 1: "+vector1+" Magnitud: "+vector1.Magnitude());
            Console.WriteLine("Vector 2: "+vector2+" Magnitud: "+vector2.Magnitude());
            Console.WriteLine("Producto Punto: "+vector1.DotProduct(vector2)+" Angulo entre ambos: "+vector1.AngleBetween(vector2));
        }
    }
}
