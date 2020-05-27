using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var  _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);
            var h = int.Parse(_[2]);
            var m = int.Parse(_[3]);

            var k = ((360 / 12 * h) + (0.5 * m)) - (360 / 60 * m);
            k = Math.Min(k, 360 - k);

            var x = (a * a) + (b * b) - ((2 * a * b) * Math.Cos(k * (Math.PI / 180)));
            Console.WriteLine(string.Format("{0:f20}",Math.Sqrt(x)));
        }
    }
}
