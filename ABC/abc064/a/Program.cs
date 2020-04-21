using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var x = int.Parse(string.Join("",s));  

            Console.WriteLine(x % 4 == 0 ? "YES" : "NO");
        }
    }
}
