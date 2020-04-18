using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = Console.ReadLine().ToCharArray().Any(c => c == '9');

            Console.WriteLine(f ? "Yes" : "No");
        }
    }
}
