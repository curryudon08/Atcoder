using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            
            var t = Console.ReadLine();
            var t2 = t.Substring(0, s.Length);

            if(s.Equals(t2)){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
