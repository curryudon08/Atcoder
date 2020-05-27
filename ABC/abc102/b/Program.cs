using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var maxV = int.MinValue;
            for(var i = 0; i < n - 1; i++){
                for(var j = i + 1; j < n; j++){
                    var x = Math.Abs(a[j] - a[i]);
                    maxV = Math.Max(maxV, x);
                }
            }

            Console.WriteLine(maxV);
        }
    }
}
