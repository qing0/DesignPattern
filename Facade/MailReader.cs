using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class MailReader
    {
        private MailReader()
        {

        }
        public static List<Property> GetProperties(string fileName)
        {
            List<Property> properties = new List<Property>();
            using(StreamReader sr=new StreamReader(fileName))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                  //测试不包含=
                    string[] split=line.Split('=');
                    if (split.Length == 2)
                    {
                        Property p = new Property
                        {
                            Name = split[0],
                            Value = split[1]
                        };
                        properties.Add(p);
                    }
                }

            }
            return properties;
        }
    }
    class Property
    {
        public string Name { get; set; }
        public string Value { get; set; }

    }
}
