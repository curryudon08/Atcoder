using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var x = int.Parse(_[1]);

            var m = new int[n];
            for(var i = 0; i < n; i++){
                m[i] = int.Parse(Console.ReadLine());
            }

            var count = m.Count();
            x -= m.Sum();
            count += x / m.Min();

            Console.WriteLine(count);
        }
    }
}
