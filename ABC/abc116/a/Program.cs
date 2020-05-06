using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var ab = int.Parse(_[0]);
            var bc = int.Parse(_[1]);

            Console.WriteLine(ab * bc / 2);
        }
    }
}
