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

            var s = (a * b) - (a + b - 1);

            Console.WriteLine(s);
        }
    }
}
