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

            var offset = new Tuple<int,int>[8];
            offset[0] = Tuple.Create(-1,-1);
            offset[0] = Tuple.Create(-1, 0);
            offset[0] = Tuple.Create(-1, 1);
            offset[0] = Tuple.Create( 0,-1);
            offset[0] = Tuple.Create( 0, 1);
            offset[0] = Tuple.Create( 1,-1);
            offset[0] = Tuple.Create( 1, 0);
            offset[0] = Tuple.Create( 1, 1);

            var r = new string[h,w];
            for(var i = 0; i < h; i++){
                for(var j = 0; j < w; j++){
                    if(m[i,j] == '-'){
                        var count = 0;
                        foreach(var o in offset){
                            var ii = i + o.Item1;
                            var jj = j + o.Item2;
                            if((ii >= 0 && ii < h) && (j >= 0 && jj < w)){
                                if(m[ii,jj] == '#'){
                                    count++;
                                }
                            }
                        }                  
                        r[i,j] = count.ToString();
                    }else{
                        r[i,j] = "#";
                    }
                }
            }


        }
    }
}
