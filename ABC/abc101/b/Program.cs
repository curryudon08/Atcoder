using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            var x = int.Parse(n);
            var s = n.ToCharArray().Select(i => int.Parse(i.ToString())).Sum();

            Console.WriteLine(x % s == 0 ? "Yes" : "No");
        }
    }
}
