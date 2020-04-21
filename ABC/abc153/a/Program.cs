using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var h = int.Parse(s[0]);
            var a = int.Parse(s[1]);

            Console.WriteLine(h % a == 0 ? h / a : h / a + 1);
        }
    }
}
