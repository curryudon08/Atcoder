using System;
using System.Linq;
using System.Collections.Generic;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().ToCharArray();

            var r = 0L;
            var g = 0L;
            var b = 0L;
            for(var i = 0; i < n; i++){
                if(s[i] == 'R'){
                    r++;
                }else if(s[i] == 'G'){
                    g++;
                }else if(s[i] == 'B'){
                    b++;
                }
            }
            var total = r * g * b;

            var count = 0L;
            for(var i = 0; i < n; i++){
                for(var j = i + 1; j < n; j++){
                    if(s[i] != s[j]){
                        var k = j * 2 - i; // j - i == k - jを変形
                        if(k < n && s[i] != s[k] && s[j] != s[k]){
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(total - count);
        }
    }
}
