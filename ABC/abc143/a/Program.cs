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

            var n = a - (b * 2);
            Console.WriteLine(n > 0 ? n : 0);
        }
    }
}
