using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var i = int.Parse(_[1]);

            Console.WriteLine(n - i + 1);
        }
    }
}
