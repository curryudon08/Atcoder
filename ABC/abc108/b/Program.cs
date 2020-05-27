using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x1 = int.Parse(_[0]);
            var y1 = int.Parse(_[1]);
            var x2 = int.Parse(_[2]);
            var y2 = int.Parse(_[3]);

            var x3 = x2 - xy;
            var y3 = y2;
            var x4 = x1 - xy;
            var y4 = y1;
            Console.WriteLine(string.Format("{0} {1} {2} {3}",x3, y3, x4, y4));
        }
    }
}
