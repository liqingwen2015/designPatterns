using System;

namespace SimpleFactoryPattern.Sample2
{
    /// <summary>
    /// 柱状图类：具体产品类
    /// </summary>
    public class HistogramChart : IChart
    {

        public HistogramChart()
        {
            Console.WriteLine("创建柱状图！");

        }

        public void Display()
        {
            Console.WriteLine("显示柱状图！");
        }

    }
}