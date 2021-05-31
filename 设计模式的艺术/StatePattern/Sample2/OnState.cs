using System;

namespace StatePattern.Sample2
{
    /// <summary>
    /// 打开
    /// </summary>
    public class OnState : State
    {
        public override void On(Switch s)
        {
            Console.WriteLine("已经打开！");
        }

        public override void Off(Switch s)
        {
            Console.WriteLine("关闭！");
            s.State = Switch.GetState("off");
        }
    }
}