using System;

namespace StatePattern.Sample2
{
    /// <summary>
    /// 关闭
    /// </summary>
    public class OffState : State
    {
        public override void On(Switch s)
        {
            Console.WriteLine("打开！");
            s.State = Switch.GetState("on");
        }

        public override void Off(Switch s)
        {
            Console.WriteLine("已经关闭！");
        }
    }
}