using System;

namespace TemplatePattern.Sample2
{
    public class CurrentAccount : Account
    {
        public override void CaculateInterest()
        {
            Console.WriteLine("按活期利率计算利息！");
        }
    }
}