using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample1
{
    public abstract class AbstractFactory
    {

        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }

    public abstract class AbstractProductA
    {

    }

    public class ConcrectProductA : AbstractProductA
    {

    }

    public abstract class AbstractProductB
    {

    }

    public class ConcrectProductB : AbstractProductB
    {

    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcrectProductA();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcrectProductB();
        }
    }
}
