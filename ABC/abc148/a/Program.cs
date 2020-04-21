using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new int[]{1,2,3};

            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var n = new int[]{a, b};

            Console.WriteLine(l.Except(n).First());
        }
    }
}
