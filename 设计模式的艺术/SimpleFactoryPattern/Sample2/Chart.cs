using System;

namespace SimpleFactoryPattern.Sample2
{
    public interface IChart
    {
        void Display();
    }

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

    public class LineChart : IChart
    {
        public LineChart()
        {
            Console.WriteLine("创建折线图！");
        }

        public void Display()
        {
            Console.WriteLine("显示折线图！");
        }
    }

    public class ChartFactory
    {
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