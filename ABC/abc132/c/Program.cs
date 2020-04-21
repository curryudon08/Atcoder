using System;
using System.Collections.Generic;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var d = Console.ReadLine().Split().Select(i => int.Parse(i)).OrderBy(i => i).ToList();

            var idx = (n / 2) - 1;
            var x = d[idx] + 1;
            var y = d[idx + 1];
            var count = 0;
            while(x <= y){
                count++;
                x++;
            }
            Console.WriteLine(count);
        }
    }
}
