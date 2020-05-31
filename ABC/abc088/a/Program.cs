using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());

            n %= 500;
            Console.WriteLine(n <= a ? "Yes" : "No");
        }
    }
}
