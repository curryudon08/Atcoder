using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Trim();

            Console.WriteLine(a >= 3200 ? s : "red");
        }
    }
}
