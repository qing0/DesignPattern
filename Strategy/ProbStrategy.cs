using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 根据以往获胜，选择下一局的手势
    /// </summary>
    internal class ProbStrategy : TheStrategy
    {
        private int[,] playArray = new int[3, 3]
        {
          {   1,1,1},
          {   1,1,1},
          {   1,1,1}
        };
        private int previewHandValue;
        //从0开始
        private int currentHandValue;
        Random random;
        public ProbStrategy(int seed)
        {
            random = new Random(seed);
        }
        public Hand NextHand()
        {
            Random random=new Random();
            ///获取此手势以往的总胜局数的随机数
            int bet=random.Next(GetSum(currentHandValue));
            int handValue;
            if (bet < playArray[currentHandValue, 0])
            {
                handValue = 0;
            }else if (bet < playArray[currentHandValue, 1] + playArray[currentHandValue, 0])
            {
                handValue = 1;
            }
            else
            {
                handValue = 2;
            }
            previewHandValue = currentHandValue;
            currentHandValue=handValue;
            
            return Hand.GetHand(handValue);
            
        }

        public void Review(bool isWon)
        {
            if (isWon)
            {
                playArray[previewHandValue, currentHandValue]++;
            }
            else
            {
                playArray[previewHandValue, (currentHandValue + 1) % 3]++;
                playArray[previewHandValue, (currentHandValue + 2) % 3]++;
            }
        }
        private int GetSum(int value)
        {
            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                sum += playArray[value,i];
            }
            return sum;
        }
    }
}
