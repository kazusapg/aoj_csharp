using System;
using System.Linq;

namespace ITP1_2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ')
                .Select(i => int.Parse(i)).ToArray();
            Array.Sort(numbers);
            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");
        }
    }
}