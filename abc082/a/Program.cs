using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).Sum();
            Console.WriteLine(Math.Ceiling(s / 2.0) );
        }
    }
}
