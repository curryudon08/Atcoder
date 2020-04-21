using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().ToCharArray();

            var l = new List<char>();
            var i = 0;
            while(i < n){
                var c = s[i];
                while(i < n && s[i] == c){
                    i++;
                }
                l.Add(c);
            }

            var s2 = string.Join("",l);
            Console.WriteLine(s2.Length);
        }
    }
}
