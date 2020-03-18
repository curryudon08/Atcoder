using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();
            var s = line[0];
            var t = line[1];

            Console.WriteLine(t + s);
        }
    }
}
