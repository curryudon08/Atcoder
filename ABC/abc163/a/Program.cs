using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0:f10}",2 * Math.PI * r));
        }
    }
}
