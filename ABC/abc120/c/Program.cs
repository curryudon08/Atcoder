using System;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
            var c0 = s.Count(i => i == 0);
            var c1 = s.Count(i => i == 1);

            Console.WriteLine(Math.Min(c0,c1) * 2);
        }
    }
}
