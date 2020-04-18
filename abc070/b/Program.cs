using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);
            var c = int.Parse(_[2]);
            var d = int.Parse(_[3]);

            var s = Math.Max(a, c);
            var e = Math.Min(b, d);
            var t = e - s;

            Console.WriteLine(t >= 0 ? t : 0);
        }
    }
}
