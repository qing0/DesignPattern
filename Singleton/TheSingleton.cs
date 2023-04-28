using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class TheSingleton
    {
        static TheSingleton instance = new TheSingleton();
        private TheSingleton()
        {

        }
        public static TheSingleton GetInstance()
        {
            return instance;
        }
    }
}
