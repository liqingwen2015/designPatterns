using System;

namespace DecoratorPattern.Sample1
{
    /// <summary>
    /// 列表框类：具体构件类
    /// </summary>
    public class ListBox:Component
    {
        public override void Display()
        {
            Console.WriteLine("显示列表框！");
        }
    }
}