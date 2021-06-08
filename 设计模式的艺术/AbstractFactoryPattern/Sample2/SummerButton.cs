using System;

namespace AbstractFactoryPattern.Sample2
{
    /// <summary>
    /// Summer 按钮类：具体产品
    /// </summary>
    public class SummerButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅蓝色按钮。");
        }
    }
}