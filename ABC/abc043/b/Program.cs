using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var f = new string[s.Length];
            var idx = 0;
            for(var i = 0; i < s.Length; i++){
                if(s[i] == '0'){
                    f[idx] = "0";
                    idx++;
                }else if(s[i] == '1'){
                    f[idx] = "1";
                    idx++;
                }else{
                    if(idx - 1 >= 0){
                        idx--;
                    }else{
                        idx = 0;
                    }
                }
            }

            for(var i = 0; i < idx; i++){
                Console.Write(f[i]);                
            }
            Console.Write("\n");
        }
    }
}
