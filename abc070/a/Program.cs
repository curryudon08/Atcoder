using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var n = new string[s.Length];
            for(var i = s.Length - 1; i >= 0; i--){
                n[s.Length - 1 - i] = s[i].ToString();
            }

            if(int.Parse(s) == int.Parse(string.Join("",n))){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
