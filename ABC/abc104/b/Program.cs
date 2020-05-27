using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();            
            var r = true;

            if(s[0] != 'A'){
                r = false;
            }

            var count = 0;
            for(var i = 1; i < s.Length; i++){
                if(char.IsUpper(s[i])){
                    if(s[i] == 'C'){
                        if((i >= 2 && i <= s.Length - 2)){
                            count++;
                        }else{
                            r = false;
                        }
                    }else{
                        r = false;
                    }
                }                
            }
            r = count != 1 ? false : r;

            Console.WriteLine(r ? "AC" : "WA");
        }
    }
}
