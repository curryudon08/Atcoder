using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();
            var a = s[0] * s[1];
            var b = s[2] * s[3];

            Console.WriteLine(a >= b ? a : b);
        }
    }
}
