using System;

namespace AbstractFactoryPattern.Sample2
{
    /// <summary>
    /// Summer 文本框类：具体产品
    /// </summary>
    public class SummerTextField : ITextField
    {
        public void Display() => Console.WriteLine("显示蓝色边框文本框。");
    }
}