using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Trim().ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
            var ans = n.Any(i => i == 7);

            Console.WriteLine(ans ? "Yes" : "No");
        }
    }
}
