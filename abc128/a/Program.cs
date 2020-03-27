using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var p = int.Parse(_[1]);

            var x = ((a * 3) + p) / 2;
            Console.WriteLine(x);
        }
    }
}
