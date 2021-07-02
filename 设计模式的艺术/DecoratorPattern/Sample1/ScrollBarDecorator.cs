using System;

namespace DecoratorPattern.Sample1
{
    /// <summary>
    /// 滚动条装饰类：具体装饰类
    /// </summary>
    public class ScrollBarDecorator : ComponentDecorator
    {
        public ScrollBarDecorator(Component component) : base(component)
        {
        }

        public override void Display()
        {
            Console.WriteLine("为构建增加滚动条！");
            base.Display();
        }
    }
}