using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();

            var count1 = 0;
            var count2 = 0;
            for(var i = 0; i < s.Length; i++){
                //0101…
                if(i % 2 == 0){
                    if(s[i] == '1'){
                        count1++;
                    }
                }else{
                    if(s[i] == '0'){
                        count1++;
                    }
                }

                //1010…
                if(i % 2 == 0){
                    if(s[i] == '0'){
                        count2++;
                    }
                }else{
                    if(s[i] == '1'){
                        count2++;
                    }
                }
            }

            Console.WriteLine(Math.Min(count1, count2));
        }
    }
}
