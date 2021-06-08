using System;

namespace AbstractFactoryPattern.Sample2
{
    /// <summary>
    /// Spring 按钮类：具体产品
    /// </summary>
    public class SpringButton : IButton
    {
        public void Display() => Console.WriteLine("显示浅绿色按钮。");
    }
}