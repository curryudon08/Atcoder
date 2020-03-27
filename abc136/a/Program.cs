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
            var c = int.Parse(_[2]);

            var m = a - b;
            Console.WriteLine(c - m >= 0 ? c - m : 0);
        }
    }
}
