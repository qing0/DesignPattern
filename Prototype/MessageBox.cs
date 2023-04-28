using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class MessageBox:Product
    {
        public string decoChar { get; set; }

        public MessageBox(string decochar)
        {
            this.decoChar = decochar;
        }

        public Product CreateClone()
        {
            Product p;
            try
            {
                p= (Product)this.Clone();
            }
            catch (Exception)
            {

                throw;
            }
            return p;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Use(string str)
        {
            for(int i = 0; i < str.Length + 4; i++)
            {
                Console.Write(decoChar);
            }
            Console.WriteLine();
            Console.WriteLine(decoChar+" "+str+" "+decoChar);
            Console.WriteLine();
            for (int i = 0; i < str.Length + 4; i++)
            {
                Console.Write(decoChar);
            }
            Console.WriteLine();
        }
    }
}
