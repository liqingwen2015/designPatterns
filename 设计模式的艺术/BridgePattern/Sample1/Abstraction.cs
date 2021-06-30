namespace BridgePattern.Sample1
{
    public abstract class Abstraction
    {
        /// <summary>
        /// 定义实现类接口对象
        /// </summary>
        protected IImplementor Implementor;

        protected Abstraction(IImplementor implementor)
        {
            Implementor = implementor;
        }

        /// <summary>
        /// 声明抽象业务方法
        /// </summary>
        public abstract void Operation();
    }
}
