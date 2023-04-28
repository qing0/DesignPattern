using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 三例
    /// </summary>
    internal class Hand
    {
        public const int HandValue_Gu = 0;//石头
        public const int HandValue_Chi = 1;//剪刀
        public const int HandValue_Pa = 2;  //布
        private static Hand[] HandArray = new Hand[] {new Hand(HandValue_Chi),new Hand(HandValue_Chi),new Hand(HandValue_Pa) };
        public string[] handName = new string[] { "石头","剪刀","布"};
        private int handValue;
        private Hand(int value)
        {
            this.handValue = value;
        }
        public static Hand GetHand(int value)
        {
            if (value > HandArray.Length - 1)
            {
                throw new ArgumentException("数值不能超过2");
              
            }
            return HandArray[value];
        }
        public string GetName()
        {
            return handName[handValue];
        }
        /// <summary>
        /// 比较输赢
        /// </summary>
        /// <returns></returns>
        private int Fight(Hand fightHand)
        {
            //当前手势：handValue
            //比较手势：fightValue
            if (this.handValue == fightHand.handValue)
            {
                return 0;
            }else if ((this.handValue + 1) % 3 == fightHand.handValue)
            {
                //handValue获胜
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public bool ThisWon(Hand fightHand)
        {
            return Fight(fightHand) == 1;
        }
        public bool ThisLose(Hand fightHand)
        {
            return Fight(fightHand) == -1;
        }
    }
}
