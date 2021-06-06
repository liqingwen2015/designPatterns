namespace TemplatePattern.Sample1
{
    public class ConcreteClass : AbstractClass
    {
        /// <summary>
        /// 实现代码
        /// </summary>
        public override void PrimitiveOperation2()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 实现代码
        /// </summary>
        public override void PrimitiveOperation3()
        {
            base.PrimitiveOperation3();
        }
    }
}