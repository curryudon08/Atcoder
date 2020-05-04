using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var p = (x - a) % b;
            Console.WriteLine(p);
        }
    }
}
