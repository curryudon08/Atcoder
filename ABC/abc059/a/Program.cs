using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(s => Convert.ToChar(s.Substring(0,1))).Select(c => char.ToUpper(c));
            Console.WriteLine(string.Join("",a));
        }
    }
}
