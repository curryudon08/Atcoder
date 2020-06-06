using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var v = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var c = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var s = Enumerable.Range(0,n).Where(i => v[i] - c[i] >= 0).Select(i => v[i] - c[i]).Sum();
            Console.WriteLine(s);
        }
    }
}
