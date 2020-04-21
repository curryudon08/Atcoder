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
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var max = a.Max();
            var min = a.Min();

            Console.WriteLine(max - min);
        }
    }
}
