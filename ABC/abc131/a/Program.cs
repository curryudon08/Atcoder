using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();

            if(s[0] == s[1] || s[1] == s[2] || s[2] == s[3]){
                Console.WriteLine("Bad");   
            }else{
                Console.WriteLine("Good");
            }
        }
    }
}
