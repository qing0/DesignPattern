using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 上一局获胜，下一句出相同手势
    /// </summary>
    class WinningStrategy : TheStrategy
    {
        private bool previewIsWon;
        private Hand previewHand;
        Random random;
        public WinningStrategy(int seed)
        {
            random=new Random(seed);
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">初始值和输局时是随机数</param>
        /// <returns></returns>
        public Hand NextHand()
        {
            if(!previewIsWon)
            {
                previewHand=Hand.GetHand(random.Next(3));
            }
            return previewHand;
        }

        public void Review(bool isWon)
        {
            previewIsWon= isWon;
        }
    }
}
