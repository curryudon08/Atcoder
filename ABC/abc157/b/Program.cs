using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var sheet = new int[3,3];
            for(var i = 0; i < 3; i++){
                var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for(var j = 0; j < 3; j++){
                    sheet[i,j] = a[j];
                }
            }

            var n = int.Parse(Console.ReadLine());
            for(var k = 0; k < n; k++){
                var b = int.Parse(Console.ReadLine());

                for(var i = 0; i < 3; i++){
                    for(var j = 0; j < 3; j++){
                        if(sheet[i,j] == b){
                            sheet[i,j] = 0;
                        }
                    }
                }
            }

            var flag = false;
            for(var i = 0; i < 3; i++){
                if(sheet[i,0] == 0 && sheet[i,1] == 0 && sheet[i,2] == 0){
                    flag = true;
                    break;
                }
                if(sheet[0,i] == 0 && sheet[1,i] == 0 && sheet[2,i] == 0){
                    flag = true;
                    break;
                }
            }

            if(sheet[0,0] == 0 && sheet[1,1] == 0 && sheet[2,2] == 0){
                flag = true;
            }
            if(sheet[0,2] == 0 && sheet[1,1] == 0 && sheet[2,0] == 0){
                flag = true;
            }

            Console.WriteLine(flag ? "Yes" : "No");
        }
    }
}
