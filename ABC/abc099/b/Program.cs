using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            var s = 0;
            for(var i = 1; i <= b - a; i++){
                s += i;
            }

            Console.WriteLine(s - b);
        }
    }
}
