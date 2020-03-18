using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var n = int.Parse(s[0]);
            var k = int.Parse(s[1]);

            var l = new List<int>();
            while(n > 0){
                l.Add(n % k);
                n /= k;
            }

            Console.WriteLine(l.Count());
        }
    }
}
