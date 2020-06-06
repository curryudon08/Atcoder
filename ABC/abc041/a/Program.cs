using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var i = int.Parse(Console.ReadLine());
            Console.WriteLine(s[i-1]);
        }
    }
}
