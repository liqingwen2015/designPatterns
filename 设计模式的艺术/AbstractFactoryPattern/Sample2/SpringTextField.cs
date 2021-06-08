using System;

namespace AbstractFactoryPattern.Sample2
{
    /// <summary>
    /// Spring 文本框类：具体产品
    /// </summary>
    public class SpringTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框文本框。");
        }
    }
}