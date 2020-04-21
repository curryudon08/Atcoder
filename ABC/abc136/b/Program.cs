using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = Enumerable.Range(1,n).Select(i => i.ToString()).Count(i => i.Length % 2 != 0);

            Console.WriteLine(count);
        }
    }
}
