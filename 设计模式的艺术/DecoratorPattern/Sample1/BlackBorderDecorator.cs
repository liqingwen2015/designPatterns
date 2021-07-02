using System;

namespace DecoratorPattern.Sample1
{
    /// <summary>
    /// 黑色边框装饰类：具体装饰类
    /// </summary>
    public class BlackBorderDecorator:ComponentDecorator
    {
        public BlackBorderDecorator(Component component) : base(component)
        {
        }

        public override void Display()
        {
            Console.WriteLine("为构件增加黑色边框！");
            base.Display();
        }
    }
}