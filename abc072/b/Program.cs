using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var odd = "";
            for(var i = 1; i <= s.Length; i++){
                if(i % 2 != 0){
                    odd += s[i - 1];
                }
            }

            Console.WriteLine(odd);
        }
    }
}
