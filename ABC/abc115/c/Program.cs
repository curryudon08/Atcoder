using System;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var k = int.Parse(_[1]);

            var h = new int[n];
            for(var i = 0; i < n; i++){
                h[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(h);

            var minVal = int.MaxValue;
            for(var i = 0; i < n - k + 1; i++){
                minVal = Math.Min(minVal, h[i + k - 1] - h[i]);
            }

            Console.WriteLine(minVal);
        }
    }
}
