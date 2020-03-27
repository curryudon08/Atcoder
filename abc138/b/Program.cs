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

            var total = 0.0;
            foreach(var i in a){
                total += (1.0 / i);
            }

            Console.WriteLine(string.Format("{0:f14}",1.0 / total));
        }
    }
}
