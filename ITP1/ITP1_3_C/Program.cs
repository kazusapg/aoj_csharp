using System;
using System.Linq;

namespace ITP1_3_C
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var xy = Console.ReadLine().Split(' ')
                    .Select(i => int.Parse(i)).ToArray();
                var x = xy[0];
                var y = xy[1];
                if (x == 0 && y == 0) break;
                if (x < y)
                    Console.WriteLine($"{x} {y}");
                else
                    Console.WriteLine($"{y} {x}");
            }
        }
    }
}