using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var h = new HashSet<int>(s);

            Console.WriteLine(h.Count() == 2 ? "Yes" : "No");
        }
    }
}
