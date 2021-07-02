using System;

namespace DecoratorPattern.Sample1
{
    /// <summary>
    /// 窗体类：具体构件类
    /// </summary>
    public class Window : Component
    {
        public override void Display()
        {
            Console.WriteLine("显示窗体！");
        }
    }
}