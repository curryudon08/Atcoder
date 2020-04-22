using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x = long.Parse(_[0]);
            var y = long.Parse(_[1]);
            var z = long.Parse(_[2]);

            var ans = (x - z) / (y + z);
            Console.WriteLine(ans);
        }
    }
}
