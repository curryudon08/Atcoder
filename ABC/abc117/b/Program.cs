using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = Console.ReadLine().Split().Select(i => int.Parse(i)).OrderByDescending(i => i).ToArray();

            var f = l.First() < l.Skip(1).Sum();
            Console.WriteLine(f ? "Yes" : "No");
        }
    }
}
