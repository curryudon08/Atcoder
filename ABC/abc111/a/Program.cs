using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();

            var o = new string[3];
            for(var i = 0; i < 3; i++){                
                if(s[i] == '1'){
                    o[i] = "9";
                }else{
                    o[i] = "1";
                }
            }

            Console.WriteLine(string.Join("",o));
        }
    }
}
