using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Trim();

            var l = new List<char>();
            foreach(var c in s.ToCharArray()){
                var i = alphabet.IndexOf(c);
                l.Add(alphabet[i + n]);
            }

            Console.WriteLine(string.Join("",l));
        }
    }
}
