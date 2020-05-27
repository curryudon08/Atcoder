using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();

            var f = false;
            for(var i = 0; i < t.Length; i++){
                s = s[s.Length - 1].ToString() + s.Substring(0, s.Length - 1);
                if(t.Equals(s)){
                    f = true;
                    break;
                }
            }

            Console.WriteLine(f ? "Yes" : "No");
        }
    }
}
