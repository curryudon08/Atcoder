using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = int.Parse(Console.ReadLine());
            var g = int.Parse(Console.ReadLine());

            var x = 2 * g - r;
            Console.WriteLine(x);
        }
    }
}
