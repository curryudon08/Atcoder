using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var a = new int[n];
            for(var i = 0; i < n; i++){
                a[i] = int.Parse(Console.ReadLine());
            }

            var m = a.Max();
            var s = a.Sum() - m + (m / 2);
            Console.WriteLine(s);
        }
    }
}
