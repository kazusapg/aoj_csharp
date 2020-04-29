using System;
using System.Linq;

namespace ITP1_3_D
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var abc = Console.ReadLine().Split(' ')
                .Select(i => int.Parse(i)).ToArray();
            var a = abc[0];
            var b = abc[1];
            var c = abc[2];

            var count = 0;
            for (var i = a; i <= b; i++)
                if (c % i == 0)
                    count++;
            Console.WriteLine(count);
        }
    }
}