using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());

            var a = k % 2 == 0 ? k / 2 : k / 2 + 1;
            var b = k / 2;

            Console.WriteLine(a * b);
        }
    }
}
