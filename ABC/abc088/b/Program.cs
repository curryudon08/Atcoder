using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var b = a.OrderByDescending(x => x).ToArray();
            var alice = Enumerable.Range(0,n).Where(x => x % 2 == 0).Select(x => b[x]).Sum();
            var bob = Enumerable.Range(0,n).Where(x => x % 2 != 0).Select(x => b[x]).Sum();

            Console.WriteLine(alice - bob);
        }
    }
}
