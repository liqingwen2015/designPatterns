using System;

namespace TemplatePattern.Sample3
{
    public abstract class DataViewer
    {
        /// <summary>
        /// 抽象方法：获取数据
        /// </summary>
        public abstract void GetData();

        /// <summary>
        /// 具体方法：转换数据
        /// </summary>
        public void ConvertData() => Console.WriteLine("将数据转换为 XML 格式");

        /// <summary>
        /// 抽象方法：显示数据
        /// </summary>
        public abstract void DisplayData();

        /// <summary>
        /// 钩子方法：判断是否为 XML 格式的数据
        /// </summary>
        /// <returns></returns>
        public virtual bool IsNotXmlData() => true;

        /// <summary>
        /// 模板方法
        /// </summary>
        public void Process()
        {
            GetData();

            // 如果不是 XML 格式的数据则进行数据转换
            if (IsNotXmlData())
            {
                ConvertData();
            }

            DisplayData();
        }
    }
}