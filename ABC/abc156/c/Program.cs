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
            var xList = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var minValue = int.MaxValue;
            foreach(var p in Enumerable.Range(1, 100)){
                var sum = 0;
                foreach(var x in xList){
                    sum += ((x - p) * (x - p));
                }
                minValue = Math.Min(minValue, sum);
            }

            Console.WriteLine(minValue);
        }
    }
}
