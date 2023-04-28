using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    internal abstract class Factory
    {
        public static Factory GetFactory(string className)
        {
            Factory factory= null;
			try
			{
                Type type = Type.GetType(className);
                object obj= Activator.CreateInstance(type);
                if(obj != null)
                {
                    factory = (Factory)obj;
                }
                //type.Assembly.CreateInstance(type.Name);
            }
			catch (Exception)
			{

				throw;
			}
            return factory;

        }

        public abstract Link CreateLink(string captionStr, string url);
        public abstract Page CreatePage(string title, string author);
        public abstract Tray CreateTray(string captionStr);
    }
}
