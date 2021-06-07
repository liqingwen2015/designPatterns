using System;

namespace SimpleFactoryPattern.Sample2
{
    /// <summary>
    /// 图表工厂类：工厂类
    /// </summary>
    public class ChartFactory
    {
        /// <summary>
        /// 静态工厂方法
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IChart GetChart(string type)
        {
            if (type.IsEqual("histogram"))
            {
                Console.WriteLine("初始化设置柱状图！");
                return new HistogramChart();
            }

            if (type.IsEqual("pie"))
            {
                Console.WriteLine("初始化设置饼状图！");
                return new PieChart();
            }

            if (type.Equals("line"))
            {
                Console.WriteLine("初始化设置折线图！");
                return new LineChart();
            }

            return default;
        }
    }
}