using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(x => int.Parse(x)).OrderByDescending(x => x).ToArray();
            var s = a[0] * 10 + a[1] + a[2];

            Console.WriteLine(s);
        }
    }
}
