using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var _ = Console.ReadLine().Split();
            var t = int.Parse(_[0]);
            var a = int.Parse(_[1]);

            var h = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var minVal = int.MaxValue;
            var idx = -1;
            for(var i = 0; i < n; i++){
                var temp = (t * 1000) - (h[i] * 6);
                var d = Math.Abs(a * 1000 - temp);
                if(minVal > d){
                    minVal = d;
                    idx = i + 1;
                }
            }

            Console.WriteLine(idx);
        }
    }
}
