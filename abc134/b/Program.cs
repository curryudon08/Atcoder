using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var d = int.Parse(_[1]);
            var i = d * 2 + 1;

            var ans = n % i == 0 ? (n / i) : ((n / i) + 1);
            Console.WriteLine(ans);
        }
    }
}
