using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            var s = (a + b) * h / 2;
            Console.WriteLine(s);
        }
    }
}
