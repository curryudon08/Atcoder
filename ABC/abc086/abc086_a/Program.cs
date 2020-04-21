using System;
using System.Linq;

namespace abc086_a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine((n[0] * n[1]) % 2 == 0 ? "Even" : "Odd");
        }
    }
}
