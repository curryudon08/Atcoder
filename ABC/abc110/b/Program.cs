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
            var m = int.Parse(_[1]);
            var x = int.Parse(_[2]);
            var y = int.Parse(_[3]);

            var xa = Console.ReadLine().Split().Select(k => int.Parse(k)).ToArray();
            var ya = Console.ReadLine().Split().Select(k => int.Parse(k)).ToArray();

            var xmax = xa.Max();
            var ymin = ya.Min();

            var f = false;
            for(var i = x + 1; i <= y; i++){
                if(i > xmax && i <= ymin){
                    f = true;
                    break;
                }
            }

            Console.WriteLine(f ? "No War" : "War");
        }
    }
}
