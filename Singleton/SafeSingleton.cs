using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class SafeSingleton
    {
        private static SafeSingleton instance = null;
        private static object obj = new object();
        private SafeSingleton()
        {

        }
        public static SafeSingleton GetInstance()
        {
            lock (obj)
            {
                if(instance== null)
                {
                    instance = new SafeSingleton();
                    Console.WriteLine(instance.ToString());
                }
            }
            return instance;
        }
    }
}
