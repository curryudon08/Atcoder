using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            var n = s.Length;

            var f1 = s.Equals(string.Join("", s.Reverse()));

            var n2 = ((n - 1) / 2);
            var s2 = s.Substring(0, n2);
            var f2 = s2.Equals(string.Join("", s2.Reverse()));

            var n3 = ((n + 3) / 2) - 1;
            var s3 = s.Substring(n3, n - n3);
            var f3 = s3.Equals(string.Join("", s3.Reverse()));


            Console.WriteLine(f1 && f2 && f3 ? "Yes" : "No");
        }
    }
}
