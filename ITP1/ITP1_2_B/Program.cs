using System;
using System.Linq;

namespace ITP1_2_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ')
                .Select(i => int.Parse(i)).ToArray();
            var a = numbers[0];
            var b = numbers[1];
            var c = numbers[2];
            if (a < b && b < c)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}