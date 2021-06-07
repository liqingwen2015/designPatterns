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
}