using System;
using System.Collections.Generic;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var k = int.Parse(_[1]);
            var s = Console.ReadLine().ToCharArray();

            s[k-1] = char.ToLower(s[k-1]);
            Console.WriteLine(string.Join("",s));
        }
    }
}
