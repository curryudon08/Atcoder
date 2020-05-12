using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x = int.Parse(_[0]);
            var y = int.Parse(_[1]);

            Console.WriteLine(x + (y / 2));
        }
    }
}
