using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal abstract class TheBuilder
    {
        private bool initialized;
        //保证先设置标题，且不能修改Director
        //添加检查调用顺序的方法,且只有子类调用，设置成protected
        public  void MakeTitle(string title)
        {
            if(!initialized)
            {
                BuildTitle(title);
            }
            initialized= true;
        }
        public  void MakeString(string str)
        {
            if(initialized)
            {
                BuildString(str);
            }
        }

        public  void MakeItems(string[] items)
        {
            if (initialized)
            {
                BuildItems(items);
            }
        }
        public  void Close()
        {
            if(initialized)
            {
                BuildDone();
            }
        }

        public abstract void BuildTitle(string title);
        public abstract void BuildString(string str);
        public abstract void BuildItems(string[] items);
        public abstract void BuildDone();
    }
}
