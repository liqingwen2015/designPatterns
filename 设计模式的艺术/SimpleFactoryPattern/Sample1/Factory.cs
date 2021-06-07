using System;

namespace SimpleFactoryPattern.Sample1
{
    public class Factory
    {
        public static Product GetProduct(string arg) =>
            arg.IsEqual("A") ? new ConcreteProductA() :
            arg.IsEqual("B") ? new ConcreteProductB() : null;
    }
}