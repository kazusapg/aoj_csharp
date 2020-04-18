using System;
using System.Linq;

namespace ITP1_1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var ab = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            var a = ab[0];
            var b = ab[1];
            Console.Write(a * b);
            Console.Write(" ");
            Console.WriteLine(a * 2 + b * 2);
        }
    }
}