using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    /// <summary>
    /// Gamer和Memento强相关
    /// program和Memento弱相关
    /// </summary>
    internal class Gamer
    {
        int money;
        List<string> fruits=new List<string>();
        static string[] fruitsName = new string[6]
        {
            "apple","orange","peach","banana","lemon","grape"
        };
        public Gamer(int _money)
        {
            this.money= _money;
        }
        public void Bet()
        {
            Random random=new Random();
            int value=random.Next(1,7);
            if (value == 1)
            {
                money += 100;
                Console.WriteLine($"金额加100，剩余{money}");
            }
            else if (value == 2)
            {
                money /= 2;
                Console.WriteLine($"金额减半，剩余{money}");
            }
            else if(value == 6)
            {
                string newFruit = GetFruit();
                fruits.Add(newFruit);
                Console.WriteLine($"获得水果:{newFruit}");
            }
        }
        public TheMemento CreateMemento()
        {
            TheMemento memento  =new TheMemento(money);
            foreach(string fruit in fruits)
            {
                //只保存tasty的
                if(fruit.StartsWith("tasty "))
                {
                    memento.AddFruit(fruit);             
                }
                      
            }
            return memento;
        }
        public void Restore(TheMemento memento)
        {
            this.money=memento.GetMoney();
            this.fruits=memento.GetFruits();
        }

        public int GetMoney()
        {
            return money;
        }

       public string GetFruit()
        {
            string prefix = "";
            Random random=new Random();
            if(random.Next() / 2 == 0)
            {
                prefix = "tasty ";
            }
            return prefix + fruitsName[random.Next(0,fruitsName.Length)];
        }
    }
}
