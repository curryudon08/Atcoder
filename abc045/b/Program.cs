using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Player{
        private int idxNow;
        private readonly char[] hand;

        public Player(string s){
            this.hand = s.ToCharArray();
            this.idxNow = 0;
        }

        public char GetNext(){
            var c = this.hand[this.idxNow];
            this.idxNow += 1;
            return c;
        }

        public bool HasNext(){
            if(this.idxNow >= this.hand.Length){
                return false;
            }else{
                return true;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<char,Player>();
            d['a'] = new Player(Console.ReadLine().Trim());
            d['b'] = new Player(Console.ReadLine().Trim());
            d['c'] = new Player(Console.ReadLine().Trim());

            var next = 'a';
            while(true){
                var player = d[next];
                if(player.HasNext()){
                    next = player.GetNext();
                }else{
                    Console.WriteLine(char.ToUpper(next));
                    break;
                }
            }
        }
    }
}
