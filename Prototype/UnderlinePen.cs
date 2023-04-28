using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class UnderlinePen : Product
    {
        public string decoChar { get; set; }
        public UnderlinePen(string decochar)
        {
            this.decoChar= decochar;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Product CreateClone()
        {
            Product p;
            try
            {
                p = (Product)this.Clone();
            }
            catch (Exception)
            {

                throw;
            }
            return p;
        }

        public void Use(string s)
        {
            Console.WriteLine("\""+s+"\"");
            for(int i = 0; i < s.Length; i++)
            {
                Console.Write(decoChar);
            }
            Console.WriteLine();
        }
    }
}
