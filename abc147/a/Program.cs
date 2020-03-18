using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).Sum();
            Console.WriteLine(a >= 22 ? "bust" : "win");
        }
    }
}
