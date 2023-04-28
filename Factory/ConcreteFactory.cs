using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// 具体加工
    /// </summary>
    internal class ConcreteFactory:TheFactory
    {
        Hashtable hash=new Hashtable();
        List<string> Owners=new List<string>();

        int number = 0;
        protected override Product CreateProduct(string owner)
        {
            return new ConcreteProduct(owner,number++);
        }

        protected override void RegisterProduct(Product p)
        {

            Owners.Add(((ConcreteProduct)p).GetOwner());
            hash.Add(((ConcreteProduct)p).GetNumber(), ((ConcreteProduct)p).GetOwner());
        }
        public List<string> GetOwners()
        {
            return Owners;
        }
        public Hashtable GetHash()
        {
            return hash;
        }
    }

}
