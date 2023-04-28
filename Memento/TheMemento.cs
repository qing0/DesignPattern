using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    /// <summary>
    /// 记录gamer某一时刻 money和fruits
    /// </summary>
    [Serializable]
    internal class TheMemento
    {
        int money;
        List<string> fruits=new List<string>();
        public int GetMoney()
        {
            return money;
        }
        public List<string> GetFruits()
        {
            return fruits;
        }
        /// <summary>
        /// 正常情况下，创建实例权限只交给Gamer
        /// program最好与gamer和memento不在同一个程序集
        /// </summary>
        /// <param name="_money"></param>
        internal TheMemento(int _money)
        {
            this.money= _money;
            //查看fruits
        }

        public void AddFruit(string fruit)
        {
            fruits.Add(fruit);
        }
       
    }
}
