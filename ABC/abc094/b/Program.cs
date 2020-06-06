using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);
            var x = int.Parse(_[2]);
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var c1 = a.Where(i => i < x).Count();
            var c2 = a.Where(i => i > x).Count();

            Console.WriteLine(Math.Min(c1,c2));
        }
    }
}
