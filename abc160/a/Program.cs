using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim().ToCharArray();
            if(s[2] == s[3] && s[4] == s[5]){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
