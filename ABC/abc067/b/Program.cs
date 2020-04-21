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
            var k = int.Parse(_[1]);
            var l = Console.ReadLine().Split().Select(i => int.Parse(i));

            var sum = l.OrderByDescending(i => i).Take(k).Sum();
            Console.WriteLine(sum);
        }
    }
}
