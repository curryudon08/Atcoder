using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);

            Console.WriteLine(n % m == 0 ? 0 : 1);
        }
    }
}
