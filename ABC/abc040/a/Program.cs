using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var x = int.Parse(_[1]);

            var ans = Math.Min(x-1,n-x);
            Console.WriteLine(ans);
        }
    }
}
