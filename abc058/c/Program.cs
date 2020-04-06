using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var d = new int[26];
            for(var i = 0; i < 26; i++){
                d[i] = int.MaxValue;
            }

            var n = int.Parse(Console.ReadLine());
            for(var i = 0; i < n; i++){
                var s = Console.ReadLine().ToCharArray();
                for(var j = 0; j < 26; j++){
                    var k = s.Count(t => t == alphabet.ElementAt(j));
                    d[j] = Math.Min(d[j], k);
                }
            }
            
            var ans = new StringBuilder();
            for(var i = 0; i < 26; i++){
                ans.Append(new string(alphabet[i], d[i]));
            }

            Console.WriteLine(ans.ToString());
        }
    }
}
