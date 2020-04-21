using System;
using System.Collections.Generic;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var n = input[0];
            var m = input[1];

            var l = new List<Tuple<int,char>>();
            foreach(var i in Enumerable.Range(0,m)){
                var x = Console.ReadLine().Split().ToArray();
                var s = int.Parse(x[0]);
                var c = Convert.ToChar(x[1]);
                l.Add(Tuple.Create(s,c));
            }

            var notDone = true;
            foreach(var i in Enumerable.Range(0, (int)Math.Pow(10,n))){
                var k = i.ToString().ToCharArray();                
                var flag = true;
                foreach(var x in l){
                    var s = x.Item1;
                    var c = x.Item2;
                    if(k.Length >= s){
                        if(k[s-1] != c){
                            flag = false;
                            break;
                        }
                    }else{
                        flag = false;
                        break;
                    }
                }
                if(flag && k.Length == n){
                    Console.WriteLine(i);
                    notDone = false;
                    break;
                }
            }

            if(notDone){
                Console.WriteLine("-1");
            }
        }
    }
}
