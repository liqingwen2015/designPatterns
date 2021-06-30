using System;

namespace BridgePattern.Sample1
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor implementor) : base(implementor)
        {
        }

        public override void Operation()
        {
            // 业务代码

            // 调用实现类的方法
            Implementor.OperationImpl();

            // 业务代码
        }
    }
}