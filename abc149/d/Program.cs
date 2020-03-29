using System;
using System.Linq;
using System.Collections.Generic;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var k = int.Parse(_[1]);

            var __ = Console.ReadLine().Split();
            var r = int.Parse(__[0]);
            var s = int.Parse(__[1]);
            var p = int.Parse(__[2]);

            var t = Console.ReadLine().ToCharArray();
            var h = new char[n];

            var point = 0;
            for(var i = 0; i < n; i++){
                var idx = i - k;
                if(t[i] == 'r'){
                    if(idx >= 0 && h[idx] == 'p'){
                        h[i] = 'x';
                        point += 0;
                    }else{
                        h[i] = 'p';
                        point += p;
                    }
                }else if(t[i] == 's'){
                    if(idx >= 0 && h[idx] == 'r'){
                        h[i] = 'x';
                        point += 0;
                    }else{
                        h[i] = 'r';
                        point += r;
                    }
                }else if(t[i] == 'p'){
                    if(idx >= 0 && h[idx] == 's'){
                        h[i] = 'x';
                        point += 0;
                    }else{
                        h[i] = 's';
                        point += s;
                    }
                }
            }

            Console.WriteLine(point);
        }
    }
}
