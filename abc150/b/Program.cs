using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Trim();

            var c = 0;
            var i = 0;
            while(true){
                if(i + 3 <= s.Length){
                    var sb = s.Substring(i,3);
                    if(sb.Equals("ABC")){
                        c += 1;
                    }
                    i += 1;
                }else{
                    break;
                }
            }

            Console.WriteLine(c);
        }
    }
}
