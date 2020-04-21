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
            var v = Console.ReadLine().Split().Select(i => double.Parse(i)).OrderBy(i => i).ToArray();

            var value = v[0];
            for(var i = 1; i < v.Length; i++){
                value = (value + v[i]) / 2.0;
            }

            Console.WriteLine(string.Format("{0:f10}",value));
        }
    }
}
