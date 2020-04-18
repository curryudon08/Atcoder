using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x = int.Parse(_[0]);
            var a = int.Parse(_[1]);
            var b = int.Parse(_[2]);

            var i = Math.Abs(x - a);
            var j = Math.Abs(x - b);

            Console.WriteLine(i > j ? "B" : "A");
        }
    }
}
