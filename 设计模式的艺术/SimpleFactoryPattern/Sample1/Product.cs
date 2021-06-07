using System;

namespace SimpleFactoryPattern.Sample1
{
    public abstract class Product
    {
        /// <summary>
        /// 所有产品的公共业务方法
        /// </summary>
        public void MethodSame()
        {
            // 公共方法的实现
        }

        /// <summary>
        /// 声明抽象业务方法
        /// </summary>
        public abstract void MethodDiff();
    }

    public class ConcreteProductA : Product
    {
        /// <summary>
        /// 实现业务方法
        /// </summary>
        public override void MethodDiff()
        {
            // 业务方法的实现
        }
    }

    public class ConcreteProductB : Product
    {
        /// <summary>
        /// 实现业务方法
        /// </summary>
        public override void MethodDiff()
        {
            // 业务方法的实现
        }
    }

    public class Factory
    {
        public static Product GetProduct(string arg) =>
            arg.IsEqual("A") ? new ConcreteProductA() :
            arg.IsEqual("B") ? new ConcreteProductB() : null;
    }
}