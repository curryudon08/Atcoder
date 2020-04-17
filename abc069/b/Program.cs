using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();

            var f = s[0] + (s.Length - 2).ToString() + s[s.Length - 1];
            Console.WriteLine(f);
        }
    }
}
