using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 委托TheStrategy进行手势判断
    /// 并记录局势输赢、比赛局数
    /// </summary>
    internal class Player
    {
        public int count;
        public int win;
        public int lose;
        TheStrategy strategy;
        public string playerName;
        public Player(string name,TheStrategy strategy)
        {
            this.playerName= name;
            this.strategy = strategy;
        }
        public Hand NextHand()
        {
            return strategy.NextHand();
        }
        public void Win()
        {
            strategy.Review(true);
            win++;
            count++;
        }
        public void Lose()
        {
            strategy.Review(false);
            lose++;
            count++;
        }
        public void Even()
        {
            count++;
        }
        public void PrintResult()
        {
            Console.WriteLine($"{this.playerName} played {count};win:{win};lose:{lose};");
        }
    }
}
