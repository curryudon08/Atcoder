using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();

            var odd = Enumerable.Range(1,s.Length).Where(i => i % 2 != 0).Select(i => s[i-1]);
            var even = Enumerable.Range(1,s.Length).Where(i => i % 2 == 0).Select(i => s[i-1]);

            var isOddGood = odd.All(c => c == 'R' || c == 'U' || c == 'D');
            var isEvenGood = even.All(c => c == 'L' || c == 'U' || c == 'D');

            Console.WriteLine(isOddGood & isEvenGood ? "Yes" : "No");
        }
    }
}
