using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var maxCnt = 0;
            for(var i = 0; i < s.Length; i++){
                for(var j = 0; i + j < s.Length; j++){
                    if(s[i + j] != 'A' && s[i + j] != 'G' && s[i + j] != 'C' && s[i + j] != 'T'){
                        break;
                    }else{
                        maxCnt = Math.Max(maxCnt, j + 1);
                    }
                }
            }

            Console.WriteLine(maxCnt);
        }
    }
}
