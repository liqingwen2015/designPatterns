using System;

namespace TemplatePattern.Sample2
{
    public class SavingAccount : Account
    {
        // 重写父类的抽象基本方法
        public override void CaculateInterest()
        {
            Console.WriteLine("按定期利率计算利息！");
        }
    }
}