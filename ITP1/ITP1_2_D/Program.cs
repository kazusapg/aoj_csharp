using System;
using System.Linq;

namespace ITP1_2_D
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(' ')
                .Select(i => int.Parse(i)).ToArray();
            var W = n[0];
            var H = n[1];
            var x = n[2];
            var y = n[3];
            var r = n[4];

            var xplusr = x + r;
            if (xplusr < 0 || W < xplusr)
            {
                Console.WriteLine("No");
                return;
            }

            var xminusr = x - r;
            if (xminusr < 0 || W < xminusr)
            {
                Console.WriteLine("No");
                return;
            }

            var yplusr = y + r;
            if (yplusr < 0 || H < yplusr)
            {
                Console.WriteLine("No");
                return;
            }

            var yminusr = y - r;
            if (yminusr < 0 || H < yminusr)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine("Yes");
        }
    }
}