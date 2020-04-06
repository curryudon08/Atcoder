using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x = int.Parse(_[0]);
            var y = int.Parse(_[1]);
            var z = int.Parse(_[2]);

            var t1 = x;
            x = y;
            y = t1;

            var t2 = x;
            x = z;
            z = t2;

            Console.WriteLine(string.Format("{0} {1} {2}", x, y, z));
        }
    }
}
