namespace AbstractFactoryPattern.Sample1
{
    public class ConcreteFactory : AbstractFactory
    {
        /// <summary>
        /// 工厂方法一
        /// </summary>
        /// <returns></returns>
        public override AbstractProductA CreateProductA()
        {
            return new ConcrectProductA();
        }

        /// <summary>
        /// 工厂方法二
        /// </summary>
        /// <returns></returns>
        public override AbstractProductB CreateProductB()
        {
            return new ConcrectProductB();
        }
    }
}