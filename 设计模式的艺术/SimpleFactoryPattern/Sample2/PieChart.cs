using System;

namespace SimpleFactoryPattern.Sample2
{
    public class PieChart : IChart
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图！");
        }

        public void Display()
        {
            Console.WriteLine("显示饼状图！");
        }
    }
}