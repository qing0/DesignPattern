using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// 具体加工
    /// </summary>
    internal class ConcreteProduct : Product
    {
        string Owner { get; set; }
        int Number { get; set; }
        public ConcreteProduct(string owner,int number)
        {
            this.Owner= owner;
            this.Number = number;
            Console.WriteLine("创建"+owner+"序号"+number.ToString()+"的产品");
        }
        public override void Use()
        {
            Console.WriteLine("使用"+Owner + "序号" + Number.ToString() + "的产品");
        }
        public string GetOwner()
        {
            return Owner;
        }
        public int GetNumber()
        {
            return Number;
        }
    }
}
