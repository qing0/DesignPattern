using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class TxtBuilder : TheBuilder
    {
        private StringBuilder text;
        public TxtBuilder()
        {
            text = new StringBuilder();
        }
        public override void BuildDone()
        {
            text.AppendLine("===================");
        }

        public override void BuildItems(string[] items)
        {
            foreach(var item in items)
            {
                text.AppendLine("·"+item);
            }
        }

        public override void BuildString(string str)
        {
            text.AppendLine("■"+str);
        }

        public override void BuildTitle(string title)
        {
            text.AppendLine("===================");
            text.AppendLine("["+title+"]");
           // text.AppendLine("\n");
        }
        public string GetResult()
        {
            return text.ToString();
        }
    }
}
