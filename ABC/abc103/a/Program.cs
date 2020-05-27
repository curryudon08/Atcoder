using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i));
            var x = s.Max();
            var y = s.Min();

            Console.WriteLine(x - y);
        }
    }
}
