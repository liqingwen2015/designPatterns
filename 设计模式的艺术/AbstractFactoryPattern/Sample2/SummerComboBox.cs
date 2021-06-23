using System;

namespace AbstractFactoryPattern.Sample2
{
    public class SummerComboBox : IComboBox
    {
        public void Display() => Console.WriteLine("显示蓝色边框组合框。");
    }
}