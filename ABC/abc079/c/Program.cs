using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().ToCharArray();
            var a = int.Parse(_[0].ToString());
            var b = int.Parse(_[1].ToString());
            var c = int.Parse(_[2].ToString());
            var d = int.Parse(_[3].ToString());

            var op = new string[]{"+", "-"};
            for(var i = 0; i < 2; i++){
                for(var j = 0; j < 2; j++){
                    for(var k = 0; k < 2; k++){
                        var x = Calc(a, b, op[i]);
                        var y = Calc(x, c, op[j]);                        
                        var z = Calc(y, d, op[k]);   

                        if(z == 7){
                            Console.WriteLine(
                                string.Format("{0}{1}{2}{3}{4}{5}{6}=7"
                                ,a,op[i],b,op[j],c,op[k],d));
                                return;
                        }                     
                    }
                }
            }
        }

        static int Calc(int x, int y, string op){
            if(op.Equals("+")){
                return x + y;
            }else{
                return x - y;
            }
        }
    }
}
