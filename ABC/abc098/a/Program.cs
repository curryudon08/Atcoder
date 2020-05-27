using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            var x = a + b;
            var y = a - b;
            var z = a * b;

            var s = Math.Max(Math.Max(x,y),z);
            Console.WriteLine(s);
        }
    }
}
