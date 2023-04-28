using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRespons
{
    internal abstract class Support
    {
        private string name;
        private Support next;
        public Support(string _name)
        {
            this.name = _name;
        }
        protected abstract bool Resolve(Trouble trouble);
        private void Fail(Trouble trouble)
        {
            Console.WriteLine($"问题{trouble.GetNum().ToString()}无法被处理");
        }
        public Support SetNext(Support _next)
        {
            this.next = _next;
            return _next;
        }
        public void SupportFun(Trouble trouble)
        {
            if(Resolve(trouble))
            {
                Console.WriteLine($"{name}处理问题{trouble.GetNum().ToString()}成功");
            }
            else if(this.next != null)
            {
                next.SupportFun(trouble);
            }
            else
            {
                Fail(trouble);
            }
        }
    }
}
