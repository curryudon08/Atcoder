using System;
using System.Linq;

namespace abc081_a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToArray().Where(x => x.Equals('1')).Count();
            Console.WriteLine(s);
        }
    }
}
