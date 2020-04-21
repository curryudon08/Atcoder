using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var k = int.Parse(s[0]);
            var x = int.Parse(s[1]);

            Console.WriteLine(500 * k >= x ? "Yes" : "No");
        }
    }
}
