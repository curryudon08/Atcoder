using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var n = int.Parse(s[0]);
            var m = int.Parse(s[1]);

            Console.WriteLine(n == m ? "Yes" : "No");
        }
    }
}
