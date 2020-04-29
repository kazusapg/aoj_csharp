using System;

namespace ITP1_3_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var index = 1;
            while (true)
            {
                var x = int.Parse(Console.ReadLine());
                if(x == 0) break;
                Console.WriteLine($"Case {index}: {x}");
                index++;
            }
        }
    }
}