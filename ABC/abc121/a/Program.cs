using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var H = int.Parse(_[0]);
            var W = int.Parse(_[1]);

            var __ = Console.ReadLine().Split();
            var h = int.Parse(__[0]);
            var w = int.Parse(__[1]);

            var s = H * W;
            s -= h * W;
            s -= ((w * H) - (h * w));

            Console.WriteLine(s);
        }
    }
}
