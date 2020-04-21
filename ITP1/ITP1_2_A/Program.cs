using System;
using System.Linq;

namespace ITP1_2_A
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ab = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            var a = ab[0];
            var b = ab[1];
            if (a < b)
                Console.WriteLine("a < b");
            else if (a > b)
                Console.WriteLine("a > b");
            else
                Console.WriteLine("a == b");
        }
    }
}