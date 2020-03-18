using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().ToArray();
            var r = "A" + s[1].Substring(0,1) + "C";

            Console.WriteLine(r);
        }
    }
}
