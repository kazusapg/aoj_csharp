using System;

namespace ITP1_1_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = int.Parse(Console.ReadLine());
            var hh = s / 3600;
            var mm = s / 60 % 60;
            var ss = s % 60;
            Console.WriteLine($"{hh}:{mm}:{ss}");
        }
    }
}
