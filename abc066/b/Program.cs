using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();

            var i = s.Length - 1;
            var len = 0;
            while(i > 1){
                if(i % 2 == 0){
                    var l = i / 2;
                    var a = s.Substring(0, l);
                    var b = s.Substring(l, l);

                    if(a.Equals(b)){
                        len = Math.Max(len, i);
                    }
                }
                i--;
            }

            Console.WriteLine(len);
        }
    }
}
