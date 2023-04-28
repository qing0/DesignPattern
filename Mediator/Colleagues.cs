using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// 具体成员不能同时继承两个父类，需要声明为接口
    /// </summary>
    internal interface Colleagues
    {
        public abstract void SetMediator(FrameMediator mediator);
        public abstract void SetColleagueEnabled(bool enabled);

    }
}
