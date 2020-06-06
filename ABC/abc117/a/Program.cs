using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var t = int.Parse(_[0]);
            var x = int.Parse(_[1]);

            var d = (1.0 * t) / x;
            Console.WriteLine(string.Format("{0:F9}",d));
        }
    }
}
