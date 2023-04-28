using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 三个实例
    /// </summary>
    internal class ThreeSingleton
    {
        private static ThreeSingleton[] instance1 = new ThreeSingleton[]
        {
             new ThreeSingleton(1),
            new ThreeSingleton(2),
            new ThreeSingleton(3)
        };
        private ThreeSingleton(int number)
        {

        }
        public static ThreeSingleton GetInstance(int number) 
        {
            Console.WriteLine("实例"+number.ToString()+":");
            return instance1[number];
        }

    }
}
