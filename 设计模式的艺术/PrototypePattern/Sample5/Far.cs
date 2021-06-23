using System;

namespace PrototypePattern.Sample5
{
    /// <summary>
    /// 可行性分析报告（Feasibility Analysis Report）类
    /// </summary>
    public class Far : IOfficialDocument
    {
        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine("《可行性分析报告》");
        }


    }
}