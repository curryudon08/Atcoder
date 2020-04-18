using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();
            Array.Sort(s);

            var a = new int[26];
            for(var i = 0; i < s.Length; i++){
                var c = Convert.ToInt32(s[i]) - 97;
                a[c] += 1;
            }

            var flag = true;
            for(var i = 0; i < 26; i++){
                if(a[i] == 0){
                    Console.WriteLine(Convert.ToChar(i + 97));
                    flag = false;
                    break;
                }
            }

            if(flag){
                Console.WriteLine("None");
            }
        }
    }
}
