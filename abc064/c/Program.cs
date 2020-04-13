using System;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var s = new int[9];
            for(var i = 0; i < n; i++){
                if(a[i] >= 1 && a[i] <= 399){
                    s[0] += 1;
                }else if(a[i] >= 400 && a[i] <= 799){
                    s[1] += 1;                    
                }else if(a[i] >= 800 && a[i] <= 1199){                    
                    s[2] += 1;
                }else if(a[i] >= 1200 && a[i] <= 1599){
                    s[3] += 1;                    
                }else if(a[i] >= 1600 && a[i] <= 1999){
                    s[4] += 1;                    
                }else if(a[i] >= 2000 && a[i] <= 2399){
                    s[5] += 1;                                        
                }else if(a[i] >= 2400 && a[i] <= 2799){
                    s[6] += 1;                                                            
                }else if(a[i] >= 2800 && a[i] <= 3199){
                    s[7] += 1;                                                            
                }else if(a[i] >= 3200){
                    s[8] += 1;                                                            
                }
            }

            var count = 0;
            for(var i = 0; i < 8; i++){
                if(s[i] > 0){
                    count += 1;
                }
            }

            var min = 0;
            if(count > 0){
                min = count;
            }else{
                min = 1;
            }

            var max = count + s[8];
            
            Console.WriteLine(string.Format("{0} {1}",min,max));
        }
    }
}

