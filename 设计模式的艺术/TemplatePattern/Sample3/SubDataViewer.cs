using System;

namespace TemplatePattern.Sample3
{
    public class SubDataViewer : DataViewer
    {
        /// <summary>
        /// 实现父类方法：获取数据
        /// </summary>
        public override void GetData() => Console.WriteLine("从 XML 文件中获取数据。");

        /// <summary>
        /// 实现父类方法：显示数据
        /// </summary>
        public override void DisplayData() => Console.WriteLine("以柱状图显示数据");

        public override bool IsNotXmlData() => false;
    }
}