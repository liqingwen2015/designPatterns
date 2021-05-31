using System;

namespace StatePattern.Sample3
{
    /// <summary>
    /// 4 倍状态类
    /// </summary>
    public class LargestState : State
    {
        public override void Display()
        {
            Console.WriteLine("4 倍大小！");
        }
    }
}