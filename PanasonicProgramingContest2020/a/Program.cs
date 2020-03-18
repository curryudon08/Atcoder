using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new int[]{1, 1, 1, 2, 1, 2, 1, 5, 2, 2, 1, 5, 1, 2, 1, 14, 1, 5, 1, 5, 2, 2, 1, 15, 2, 2, 5, 4, 1, 4, 1, 51};
            var k = int.Parse(Console.ReadLine());

            Console.WriteLine(s[k-1]);
        }
    }
}
