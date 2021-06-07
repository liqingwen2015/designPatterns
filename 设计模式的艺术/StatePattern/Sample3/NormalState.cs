using System;

namespace StatePattern.Sample3
{
    /// <summary>
    /// 正常状态类
    /// </summary>
    public class NormalState : State
    {
        public override void Display() => Console.WriteLine("正常大小！");
    }
}