using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// 框架
    /// 负责创建实例的模板，创建实例需要先createProduct、RegisterProduct
    /// 具体的创建交给子类工厂
    /// </summary>
    internal abstract class TheFactory
    {
        /// <summary>
        /// 使用virtual修饰的方法，可以被子类重写
        /// 不用virtual,子类不能重写
        /// </summary>
        /// <returns></returns>
        public  Product Create(string owner)
        {
            Product p=CreateProduct(owner);
            RegisterProduct(p);
            return p;
        }
        protected abstract Product CreateProduct(string owner);
        protected abstract void RegisterProduct(Product p);

    }
}
