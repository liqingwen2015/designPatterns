using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample1
{
    public abstract class AbstractFactory
    {
        /// <summary>
        /// 工厂方法一
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProductA CreateProductA();

        /// <summary>
        /// 工厂方法二
        /// </summary>
        /// <returns></returns>
        public abstract AbstractProductB CreateProductB();
    }
}
