using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var h = int.Parse(_[0]);
            var w = int.Parse(_[1]);

            var m = new char[h,w];
            for(var i = 0; i < h; i++){
                var s = Console.ReadLine().ToCharArray();
                for(var j = 0; j < w; j++){
                    m[i,j] = s[j];
                }
            }

            var f = new bool[h,w];
            Check1(h, w, m, f);
            Check2(h, w, m, f);

            for(var i = 0; i < h; i++){
                var r = false;
                for(var j = 0; j < w; j++){
                    if(!f[i,j]){
                        r = true;
                        Console.Write(m[i,j]);
                    }
                }
                if(r){
                    Console.Write("\n");
                }
            }
        }

        static void Check1(int h, int w, char[,] m, bool[,] f){
            for(var i = 0; i < h; i++){
                var count = 0;
                for(var j = 0; j < w; j++){
                    if(m[i,j] == '.'){
                        count++;
                    }
                }

                if(count == w){
                    for(var j = 0; j < w; j++){
                        f[i,j] = true;
                    }
                }
            }
        }

        static void Check2(int h, int w, char[,] m, bool[,] f){
            for(var j = 0; j < w; j++){
                var count = 0;
                for(var i = 0; i < h; i++){
                    if(m[i,j] == '.'){
                        count++;
                    }
                }

                if(count == h){
                    for(var i = 0; i < h; i++){
                        f[i,j] = true;
                    }
                }
            }
        }
    }
}
