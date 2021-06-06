namespace TemplatePattern.Sample1
{
    public abstract class AbstractClass
    {
        /// <summary>
        /// 模板方法
        /// </summary>
        public void TemplateMethod()
        {
        }

        /// <summary>
        /// 基本方法 - 具体方法
        /// </summary>
        public void PrimitiveOperation1()
        {
             
        }

        /// <summary>
        /// 基本方法 - 抽象方法
        /// </summary>
        public abstract void PrimitiveOperation2();

        /// <summary>
        /// 基本方法 - 钩子方法
        /// </summary>
        public virtual void PrimitiveOperation3()
        {
        }
    }
}