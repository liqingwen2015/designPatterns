using System;

namespace StatePattern.Sample3
{
    /// <summary>
    /// 2 倍状态类
    /// </summary>
    public class LargerState : State
    {
        public override void Display() => Console.WriteLine("2 倍大小！");
    }
}