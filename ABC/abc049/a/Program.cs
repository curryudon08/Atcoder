using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new char[]{'a', 'e', 'i', 'o', 'u'};
            var c = Convert.ToChar(Console.ReadLine());

            if(l.Contains(c)){
                Console.WriteLine("vowel");
            }else{
                Console.WriteLine("consonant");
            }
        }
    }
}
