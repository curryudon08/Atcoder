using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = Console.ReadLine().Split().Select(i => int.Parse(i)).Sum();

            Console.WriteLine(sum >= 10 ? "error" : sum.ToString());
        }
    }
}
