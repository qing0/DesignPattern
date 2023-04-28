using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface TheStrategy
    {
        /// <summary>
        /// 根据上一局结果判断下一局手势
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        Hand NextHand();
        /// <summary>
        /// 上一局输赢
        /// </summary>
        /// <param name="isWon"></param>
        void Review(bool isWon);
    }
}
