using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 单例序号累加
    /// </summary>
    internal class SerialSingleton
    {
        private static SerialSingleton instance=new SerialSingleton();
        private static int serial = 0;
        private object obj=new object();
        private SerialSingleton()
        {
          
        }
        public static SerialSingleton GetInstance()
        {
            return instance;
        }
        public int GetSerial()
        {
            lock (obj)
            {
                serial++;
                Console.WriteLine(serial.ToString());
                return serial;
            }
        }   
    }
}
