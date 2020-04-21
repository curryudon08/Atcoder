using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).OrderBy(i => i).Take(2).Sum();
            Console.WriteLine(s);
        }
    }
}
