using System;

namespace AbstractFactoryPattern.Sample2
{
    /// <summary>
    /// Spring 组合框类：具体产品
    /// </summary>
    public class SpringComboBox : IComboBox
    {
        public void Display() => Console.WriteLine("显示绿色边框组合框。");
    }
}