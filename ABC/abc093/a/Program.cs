    using System;

    namespace a
    {
        class Program
        {
            static void Main(string[] args)
            {
                var s = Console.ReadLine().Trim();            
                var f = s.Contains("a") && s.Contains("b") && s.Contains("c");
                Console.WriteLine(f ? "Yes" : "No");
            }
        }
    }
