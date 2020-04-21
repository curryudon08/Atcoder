using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var h = Console.ReadLine().Split().Select(k => int.Parse(k)).ToList();

            var i = 0;
            var maxVal = 0;
            while(i < n){
                var move = 0;
                while(i < n - 1 && h[i] >= h[i+1]){
                    i++;
                    move++;
                }
                maxVal = Math.Max(maxVal, move);
                i++;
            }

            Console.WriteLine(maxVal);
        }
    }
}
