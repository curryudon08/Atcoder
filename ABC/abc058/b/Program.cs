using System;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = Console.ReadLine().ToCharArray();
            var e = Console.ReadLine().ToCharArray();
            var l = o.Length > e.Length ? o.Length : e.Length;

            var sb = new StringBuilder();
            for(var i = 0; i < l; i++){
                if(i < o.Length){
                    sb.Append(o[i]);
                }
                if(i < e.Length){
                    sb.Append(e[i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
